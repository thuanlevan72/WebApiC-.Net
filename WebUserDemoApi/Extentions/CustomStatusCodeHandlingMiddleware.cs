using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace WebUserDemoApi.Extentions
{
    public class CustomStatusCodeHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomStatusCodeHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex) {
                await HandleExceptionAsync(context, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            string pattern = @"(.*?) \${(.*?)}";
            Match match = Regex.Match(ex.Message, pattern);
            string message = ex.Message;
            context.Response.StatusCode = 500;
            if (match.Success)
            {
                string part1 = match.Groups[1].Value.Trim(); // "Mật khẩu sai"
                int statusCO = Int32.Parse(match.Groups[2].Value.Trim()); // "401"
                context.Response.StatusCode = statusCO;
                message = part1;
            }
            await context.Response.WriteAsync(message);
        }
    }
}
