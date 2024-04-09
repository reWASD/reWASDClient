using Newtonsoft.Json;
using reWASDProtocol.DataTransferObjects;
using reWASDProtocol;
using reWASDProtocol.Infrastructure;
using System.Runtime.InteropServices;
using reWASDProtocol.Infrastructure.Enums;

namespace reWASDHttpClient.Http.Services
{
    public class GameService(reWASDProtocol.Client.HttpClient client) : BaseHttpService(client)
    {
        private const string _prefix = $"{Constants.VERSION_PROTOCOL}/GameService";

        #region Games

        public async Task<List<GameDto>> GetGames()
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/Games");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<List<GameDto>>(await resp.Content.ReadAsStringAsync())!;
        }

        public async Task<GameDto> CreateGame(NewGameParams newGameParams)
        {
            var json = JsonConvert.SerializeObject(newGameParams);
            var resp = await Client.PostRequestAsync($"{_prefix}/Games", json);
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<GameDto>(await resp.Content.ReadAsStringAsync())!;
        }

        public async Task RenameGame(Guid id, string newName)
        {
            RenameGameParams gameParams = new()
            {
                Id = id,
                NewName = newName
            };
            var json = JsonConvert.SerializeObject(gameParams);
            var resp = await Client.PostRequestAsync($"{_prefix}/RenameGame", json);
            ProcessResponseError(resp);
        }

        public async Task DeleteGame(Guid gameId)
        {
            var resp = await Client.DeleteRequestAsync($"{_prefix}/Games/{gameId}");
            ProcessResponseError(resp);
        }

        #endregion

        #region Configs

        public async Task<List<ConfigDto>> GetConfigs(Guid gameId)
        {
            var resp = await Client.GetRequestAsync($"{_prefix}/Games/{gameId}/Configs");
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<List<ConfigDto>>(await resp.Content.ReadAsStringAsync())!;
        }
        public async Task<ConfigDto> CreateConfig(Guid gameId, string configName, VirtualGamepadType virtualType)
        {
            NewConfigParams newConfigParams = new()
            {
                GameId = gameId,
                ConfigName = configName,
                VirtualGamepadType = virtualType
            };

            var json = JsonConvert.SerializeObject(newConfigParams);
            var resp = await Client.PostRequestAsync($"{_prefix}/Configs", json);
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<ConfigDto>(await resp.Content.ReadAsStringAsync())!;
        }

        public async Task RenameConfig(RenameConfigParams configParams)
        {
            var json = JsonConvert.SerializeObject(configParams);
            var resp = await Client.PostRequestAsync($"{_prefix}/RenameConfig", json);
            ProcessResponseError(resp);
        }

        public async Task DeleteConfig(Guid configId)
        {
            var resp = await Client.DeleteRequestAsync($"{_prefix}/Configs/{configId}");
            ProcessResponseError(resp);
        }

        public async Task<ImportConfigResult> ImportConfig(ImportConfigInfo importParams)
        {
            var json = JsonConvert.SerializeObject(importParams);
            var resp = await Client.PostRequestAsync($"{_prefix}/ImportConfig", json);
            ProcessResponseError(resp);

            return JsonConvert.DeserializeObject<ImportConfigResult>(await resp.Content.ReadAsStringAsync())!;
        }
        
        #endregion
    }
}
