using Azure;

namespace WebUserDemoApi.helpers
{
    public class CookieHelper
    {
        public bool CreateCookie(string token, HttpResponse response) {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.UtcNow.AddHours(4), // Đặt thời gian tồn tại là 4 giờ
                HttpOnly = true, // Đảm bảo rằng cookie chỉ sẽ được truy cập thông qua HTTP
                SameSite = SameSiteMode.Strict, // Xác định SameSite để bảo mật cookie
                Secure = true // Đảm bảo rằng cookie chỉ được gửi qua HTTPS
            };
            response.Cookies.Append("accessToken", token, cookieOptions);
            return true;
        }
    }
}
