using System.Net;
using Newtonsoft.Json;
using reWASDHttpClient.Exceptions;
using HttpClient = reWASDProtocol.Client.HttpClient;

namespace reWASDHttpClient.Http.Services
{
    public class BaseHttpService
    {
        protected readonly HttpClient Client;
        public BaseHttpService(HttpClient client)
        {
            Client = client;
        }

        protected void ProcessResponseError(HttpResponseMessage resp)
        {
            if (resp.IsSuccessStatusCode)
                return;

            var msg = "";
            if (resp.StatusCode == HttpStatusCode.BadRequest)
            {
                var resJson = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                try
                {
                    msg = JsonConvert.DeserializeObject<ErrorMessage>(resJson)?.Message;
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            if (string.IsNullOrWhiteSpace(msg))
            {
                msg = resp.ReasonPhrase ?? "";
            }

            throw new HttpException(resp.StatusCode, msg);
        }

        protected bool CheckResponseError(HttpResponseMessage resp)
        {
            if (!resp.IsSuccessStatusCode)
            {
                string msg = "";
                if (resp.StatusCode == HttpStatusCode.BadRequest)
                {
                    var resJson = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    msg = resJson;
                }

                if (string.IsNullOrWhiteSpace(msg))
                {
                    msg = $"Code: {Convert.ToInt32(resp.StatusCode)} {resp.ReasonPhrase}";
                }

                Console.WriteLine($"Response error: {msg}");
                return false;
            }

            return true;
        }
    }
}
