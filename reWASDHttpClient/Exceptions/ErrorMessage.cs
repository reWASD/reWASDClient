using Newtonsoft.Json;

namespace reWASDHttpClient.Exceptions
{
    [JsonObject]
    internal class ErrorMessage(string message)
    {
        public string Message { get; init; } = message;
    }
}
