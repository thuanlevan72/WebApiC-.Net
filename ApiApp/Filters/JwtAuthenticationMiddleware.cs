using ApiApp.Helpers;
using System.IdentityModel.Tokens.Jwt;

namespace ApiApp.Filters
{
    public class JwtAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly SessionHelper _sessionHelper;

        public JwtAuthenticationMiddleware(RequestDelegate next, SessionHelper sessionHelper)
        {
            _next = next;
            _sessionHelper = sessionHelper;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                var jwtToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;
                var jti = jwtToken?.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti)?.Value;

                if (jti != null)
                {
                    _sessionHelper.SetSession("UserId", jti);
                }
            }

            await _next(context);
        }
    }
}
