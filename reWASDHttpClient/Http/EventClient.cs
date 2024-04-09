using LaunchDarkly.EventSource;
using Newtonsoft.Json;
using reWASDProtocol;
using reWASDProtocol.Converters;
using reWASDProtocol.Events;
using reWASDProtocol.Events.Desktop;

namespace reWASDHttpClient.Http
{
    public class EventClient : IDisposable
    {
        private EventSource? _eventSource;

        public static string ClientId = Guid.NewGuid().ToString();

        private readonly string _ip;
        private readonly uint _port;
        public EventClient(string ip, uint port)
        {
            _ip = ip;
            _port = port;
        }

        public void OnMessageReceived(object? sender, MessageReceivedEventArgs args)
        {
            try
            {
                if(!Enum.TryParse(args.EventName, out EventType type))
                    return;

                // ignore UI events
                if (type >= EventType.UIAllControllersDisconnected)
                    return;

                var data = args.Message.Data;

                switch (type)
                {
                    case EventType.Heartbeat:
                        break;
                    case EventType.BatteryLevel:
                        var batteryEvent = JsonConvert.DeserializeObject<BatteryLevelChangedEvent>(data);
                        if (batteryEvent == null) return;
                        var batteryInfo = batteryEvent.BatteryInfo;
                        Console.WriteLine("Battery of controller {0} changed {1}",
                            batteryEvent.ControllerDisplayName,
                            batteryInfo.IsLevelInPercents ? batteryInfo.LevelInPercents : batteryInfo.Level);
                        break;

                    case EventType.ControllerChanged:
                        var changedEvent = JsonConvert.DeserializeObject<ControllerChangedEvent>(data, new ControllerConverter());
                        Console.WriteLine("Controller was changed: {0}", changedEvent?.Controller.DisplayName);
                        break;

                    case EventType.ControllerAdded:
                        var controllerData = JsonConvert.DeserializeObject<ControllerConnectedEvent>(data, new ControllerConverter());
                        Console.WriteLine("Controller added: {0}", controllerData?.Controller.DisplayName);
                        break;

                    case EventType.ControllerRemoved:
                        var controllerDisconnectedData = JsonConvert.DeserializeObject<ControllerDisconnectedEvent>(data, new ControllerConverter());
                        Console.WriteLine("Controller added: {0}", controllerDisconnectedData?.ControllerDisplayName);
                        break;

                    case EventType.ControllerStateChanged:
                        var stateChangedEvent = JsonConvert.DeserializeObject<GamepadStateChangedEvent>(data);
                        if (stateChangedEvent == null) return;
                        Console.WriteLine("Controller {0} is {1}", stateChangedEvent.ControllerDisplayName, stateChangedEvent.IsOnline ? "online" : "offline");
                        break;

                    case EventType.SlotChanged:
                        var slotChangedData = JsonConvert.DeserializeObject<SlotChangedEvent>(data);
                        Console.WriteLine("Slot changed {0} to {1}", slotChangedData?.ControllerDisplayName, slotChangedData?.Slot.ToString());
                        break;

                    case EventType.ConfigApplied:
                        var configAppliedData = JsonConvert.DeserializeObject<ConfigAppliedEvent>(data);
                        Console.WriteLine("Config applied to {0}", configAppliedData?.ControllerDisplayName);
                        break;

                    case EventType.RemapStateChanged:
                        var remapStateChanged = JsonConvert.DeserializeObject<RemapStateChangedEvent>(data);
                        Console.WriteLine("Remap state changed: {0}, {1}", remapStateChanged?.ControllerDisplayName, remapStateChanged?.RemapState.ToString());
                        break;

                    case EventType.ConfigSaved:
                        var configSavedData = JsonConvert.DeserializeObject<ConfigSavedEvent>(data);
                        Console.WriteLine("Config was saved: {0}", configSavedData?.Id);
                        break;

                    case EventType.ConfigRenamed:
                        var renamedData = JsonConvert.DeserializeObject<ConfigRenamedEvent>(data);
                        Console.WriteLine("Config was renamed: {0}", renamedData?.NewName);
                        break;

                    case EventType.ConfigDeleted:
                        var configDeletedData = JsonConvert.DeserializeObject<ConfigDeletedEvent>(data);
                        Console.WriteLine("Config was deleted: {0}", configDeletedData?.Id);
                        break;

                    case EventType.GameDeleted:
                        var gameData = JsonConvert.DeserializeObject<GameDeletedEvent>(data);
                        Console.WriteLine("Game was deleted: {0}", gameData?.Id);
                        break;

                    case EventType.GameRenamed:
                        var gameRenamedData = JsonConvert.DeserializeObject<GameRenamedEvent>(data);
                        Console.WriteLine("Game was renamed: {0}", gameRenamedData?.NewName);
                        break;

                    case EventType.ShiftChanged:
                        var shiftChangedData = JsonConvert.DeserializeObject<ShiftChangedEvent>(data);
                        Console.WriteLine("Shift was changed at: {0}", shiftChangedData?.Shift);
                        break;

                    case EventType.CompositeSettingsChanged:
                        Console.WriteLine("Composite settings were changed");
                        break;

                    case EventType.AllControllersDisconnected:
                        Console.WriteLine("All controllers were disconnected");
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in SSEClient: {ex.Message}");
            }
        }

        private void Run()
        {
            try
            {
                var url = $"http://{_ip}:{_port}/{Constants.VERSION_PROTOCOL}/Events";
                var config = Configuration.Builder(new Uri(url)).Build();
                _eventSource = new EventSource(config);
                _eventSource.MessageReceived += OnMessageReceived;

                _eventSource.StartAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to run SSE");
                Console.WriteLine(e.Message);
            }
        }

        public void InitAndRun()
        {
            Run();
        }
        public void Restart()
        {
            _eventSource?.Close();
            Run();
        }

        public void StopAndClose()
        {
            _eventSource?.Close();
        }

        #region IDisposable implementation
        bool disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                StopAndClose();
            }

            disposed = true;
        }
        ~EventClient()
        {
            Dispose(false);
        }
        #endregion

    }

}
