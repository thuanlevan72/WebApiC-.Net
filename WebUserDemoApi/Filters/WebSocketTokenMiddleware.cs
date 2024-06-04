using Azure.Core;
using System.IO;

namespace WebUserDemoApi.Filters
{
    public class WebSocketTokenMiddleware
    {
        private readonly RequestDelegate _next;

        public WebSocketTokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            var token = context.Request.Query["userId"];
            Console.WriteLine(token);
            //var path = context.Request.Path;
            //Console.WriteLine(path);
            //if (path.StartsWithSegments("/api/ws/WebSocket") || path.StartsWithSegments("/ws") || path.StartsWithSegments("/ws"))
            //{
            //    if (!string.IsNullOrEmpty(token))
            //    {
            //        var cookies = context.Request.Cookies;
            //        cookies.TryGetValue("accessToken", out string accessToken);
            //        Console.WriteLine(accessToken);
               
            //    }
            //    else
            //    {
            //        context.Response.StatusCode = (int)System.Net.HttpStatusCode.Unauthorized;
            //        return;
            //    }
            //}

            await _next(context);

        }
    }
}
