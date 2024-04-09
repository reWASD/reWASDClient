using reWASDHttpClient.Http;
using reWASDProtocol.DataTransferObjects.Controllers;
using reWASDProtocol.Infrastructure.Enums;
using reWASDProtocol.DataTransferObjects;
using reWASDProtocol.Infrastructure;

namespace reWASDHttpClient
{
    internal static class Client
    {
        private const string Address = "127.0.0.1";
        private const int Port = 35474;

        private static async Task<reWASDClient?> ConnectToRewasd(bool useEvents = false)
        {
            var client = new reWASDClient(Address, Port, useEvents);

            var isChecked = await client.CheckVersion();
            Console.WriteLine(isChecked ? "Version is OK" : "Version is NOT OK");
            Console.WriteLine($"{Environment.NewLine}");

            return isChecked ? client : null;
        }

        public static async Task PrintControllersWithAppliedConfigs()
        {
            var client = await ConnectToRewasd();
            if (client is null)
                return;

            var controllers = await client.GamepadService.GetControllers();
            if (!controllers.Any())
            {
                Console.WriteLine($"Controllers is absent.{Environment.NewLine}");
                return;
            }

            await ControllersWithConfigs(controllers, client);
        }

        private static async Task ControllersWithConfigs(List<BaseControllerDto> controllers, reWASDClient client)
        {
            Console.WriteLine($"Controllers:");
            foreach (var controller in controllers)
            {
                Console.WriteLine("      {0}", controller.DisplayName);
                Console.WriteLine("          Remap state: {0}", controller.RemapState.ToString());
                if (controller.RemapState != RemapState.NothingApplied)
                {
                    Console.WriteLine("          Applied config:");
                    foreach (Slot slot in Enum.GetValues(typeof(Slot)))
                    {
                        var appliedConfig = await client.GamepadService.GetAppliedConfig(controller.Guid, slot);
                        if (appliedConfig != null)
                        {
                            Console.WriteLine("          {0}: {1}", slot.ToString(), appliedConfig.Name);
                        }
                    }
                }

                Console.WriteLine($"{Environment.NewLine}");
            }
        }

        public static async Task PrintGamesWithConfigs()
        {
            var client = await ConnectToRewasd();
            if (client is null)
                return;

            var games = await client.GameService.GetGames();
            GamesWithConfigs(games);
        }

        private static void GamesWithConfigs(List<GameDto> games)
        {
            Console.WriteLine("Games:");
            foreach (var game in games)
            {
                Console.WriteLine("      {0}", game.Name);
                Console.WriteLine("      Configs:");
                foreach (var config in game.ConfigCollection)
                {
                    Console.WriteLine("          {0}", config.Name);
                }

                Console.WriteLine($"{Environment.NewLine}");
            }

            Console.WriteLine($"{Environment.NewLine}");
        }

        public static async Task TryRemapWithEvents()
        {
            var client = await ConnectToRewasd(true);
            if (client is null)
                return;

            var controllers = await client.GamepadService.GetControllers();
            if (controllers.Any())
            {
                var games = await client.GameService.GetGames();
                await Remap(controllers, games, client);
            }
        }

        static async Task Remap(List<BaseControllerDto> controllers, List<GameDto> games, reWASDClient client)
        {
            Console.WriteLine("Test of appling of config to controller");

            var controller = controllers.FirstOrDefault(item => item.IsOnline);
            if (controller is null)
            {
                Console.WriteLine($"There are not any online controller {Environment.NewLine}");
                return;
            }

            var config = games.FirstOrDefault()?.ConfigCollection.FirstOrDefault();
            if (config is null)
            {
                Console.WriteLine($"There are not any config {Environment.NewLine}");
                return;
            }

            var info = new ConfigApplyInfo
            {
                ControllerGuid = controller.Guid,
                Path = config.Path,
                Bundle = null,
                Slot = Slot.Slot1
            };

            await client.GamepadService.ConfigApply(info);

            await Task.Delay(5000);
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Test of disable remap");
            await client.GamepadService.DisableRemap(controller.Guid);

            await Task.Delay(5000);
            Console.WriteLine($"{Environment.NewLine}");
            Console.WriteLine("Test of enable remap");
            await client.GamepadService.EnableRemap(controller.Guid, true);
        }
    }
}
