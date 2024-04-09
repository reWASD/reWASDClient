using Newtonsoft.Json;
using reWASDHttpClient.Http.Services;
using reWASDProtocol;
using reWASDProtocol.DataTransferObjects;
using HttpClient = reWASDProtocol.Client.HttpClient;

namespace reWASDHttpClient.Http
{
    public class reWASDClient
    {
        private readonly HttpClient _client;

        public reWASDClient(string ip, uint port, bool useEvents)
        {
            _client = new HttpClient(ip, port);

            GamepadService = new ControllerService(_client);
            GameService = new GameService(_client);

            if (useEvents)
            {
                var eventHandler = new EventClient(ip, port);
                eventHandler.InitAndRun();
            }
        }

        public ControllerService GamepadService { get; }
        public GameService GameService { get; }

        public async Task<bool> CheckVersion()
        {
            var response = await _client.GetRequestAsync("Version");
            if (!response.IsSuccessStatusCode)
                return false;

            var body = await response.Content.ReadAsStringAsync();
            var httpVersion = JsonConvert.DeserializeObject<HttpVersion>(body);
            return httpVersion?.Version == Constants.VERSION_PROTOCOL;
        }
    }
}
