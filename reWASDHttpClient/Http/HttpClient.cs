using System.Diagnostics;
using System.Text;
using reWASDHttpClient.Exceptions;

namespace reWASDProtocol.Client
{
    public class HttpClient
    {
        private readonly System.Net.Http.HttpClient _client = new();
        private readonly string _basePrefix;

        public HttpClient(string ip, uint port)
        {
            _basePrefix = $"http://{ip}:{port}/";

            _client.Timeout = new TimeSpan(0, 0, 15);
            _client.DefaultRequestHeaders.ConnectionClose = true;
        }

        private HttpRequestMessage Request(HttpMethod method, string route, string? json = null)
        {
            var request = new HttpRequestMessage(method, _basePrefix + route);
            if (json is null)
                return request;

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = content;
            return request;
        }

        public async Task<HttpResponseMessage> PostRequestAsync(string route, string? json = null)
        {
            return await SendRequestAsync(Request(HttpMethod.Post, route, json));
        }

        public async Task<HttpResponseMessage> GetRequestAsync(string route)
        {
            return await SendRequestAsync(Request(HttpMethod.Get, route));
        }

        public async Task<HttpResponseMessage> DeleteRequestAsync(string route)
        {
            return await SendRequestAsync(Request(HttpMethod.Delete, route));
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request)
        {
            try
            {
                return await _client.SendAsync(request);
            }
            catch (HttpRequestException ex)
            {
                throw new ConnectException(ex.Message);
            }
        }
    }
}
