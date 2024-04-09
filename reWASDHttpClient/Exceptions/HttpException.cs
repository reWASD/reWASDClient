using System.Net;

namespace reWASDHttpClient.Exceptions
{
    public class HttpException(HttpStatusCode statusCode, string message) : 
        Exception(message)
    {
        public HttpStatusCode StatusCode { get; init; } = statusCode;
    }
}
