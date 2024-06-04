using Infrastructure.Repositories.InterfaceRepository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ApiApp.Extentions
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        // Constructor của JwtMiddleware, chấp nhận các tham số là RequestDelegate và IOptions<AppSettings>.
        public JwtMiddleware(RequestDelegate next, IServiceScopeFactory serviceScopeFactory, IConfiguration configuration)
        {
            _next = next;
            _serviceScopeFactory = serviceScopeFactory;
            _configuration = configuration;
        }

        // Hàm này sẽ được gọi khi middlware xử lý một request.
        public async Task Invoke(HttpContext context)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

                if (token != null)
                    AttachUserToContext(context, token, unitOfWork);
            }


            // Di chuyển đến middleware kế tiếp trong pipeline.
            await _next(context);
        }

        // Giải mã token và gắn thông tin user vào HttpContext.
        private async void AttachUserToContext(HttpContext context, string token, IUnitOfWork unitOfWork)
        {
            try
            {
                // Tạo một instance của JwtSecurityTokenHandler để thao tác với JWT.
                var tokenHandler = new JwtSecurityTokenHandler();

                // Validate token: đảm bảo token đã không bị thay đổi từ khi nó được tạo và có hiệu lực (không quá hạn).
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                    .GetBytes(_configuration.GetSection("AppSettings:Token").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                // Ép token đã được validate thành JwtSecurityToken để có thể truy cập các claims.
                var jwtToken = (JwtSecurityToken)validatedToken;
                // Lấy UserID từ các claims của token.
                var username = jwtToken.Claims.First(x => x.Type == "username")?.Value;
                var data = unitOfWork.UserRepository.FilterAsync(x => x.userName == username).ToList();
                // Lấy thông tin người dùng từ database bằng ID và đặt vào HttpContext để sử dụng sau này.
                context.Items["User"] = data.FirstOrDefault();
            }
            catch
            {
                // Đặt bên trong try-catch để tránh lỗi nếu token không hợp lệ.
                // Nếu token không hợp lệ, chúng ta để request đó đi qua và các middleware tiếp theo hoặc controller sẽ xử lý tình huống này.
            }
        }
    }
}
