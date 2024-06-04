namespace WebUserDemoApi.Extentions
{
    public static class AuthorizationOptionsExtensions
    {
        public static void AddCurrentAccountPolicy(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("CURRENTUSER", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        var httpContext = context.Resource as HttpContext;

                        if (httpContext != null)
                        {
                            // Truy cập thông tin yêu cầu từ HttpContext
                            var request = httpContext.Request;
                            string tokenRequest = request.Headers.Authorization;
                            if (tokenRequest != null && tokenRequest.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
                            {
                                tokenRequest = tokenRequest.Substring("Bearer ".Length);
                            }
                            var cookies = request.Cookies;
                            // Lấy giá trị của một Cookie cụ thể ( Hình như là sai )
                            if (cookies.TryGetValue("accessToken", out string accessToken))
                            {
                                if (accessToken != tokenRequest)
                                {
                                    return false;
                                }
                            }
                            return true;
                        }

                        // Trong trường hợp không thể truy cập HttpContext
                        return false;
                    });
                });
            }
            );
        }
    }
}
