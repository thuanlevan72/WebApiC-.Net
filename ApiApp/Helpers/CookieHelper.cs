namespace ApiApp.Helpers
{
    public class CookieHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CookieHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Thêm một cookie mới.
        /// </summary>
        /// <param name="key">Tên của cookie.</param>
        /// <param name="value">Giá trị của cookie.</param>
        /// <param name="expireTime">Thời gian hết hạn của cookie (tính bằng phút).</param>
        public void SetCookie(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMinutes(30); // Mặc định là 30 phút

            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, option);
        }

        /// <summary>
        /// Lấy giá trị của một cookie.
        /// </summary>
        /// <param name="key">Tên của cookie.</param>
        /// <returns>Giá trị của cookie hoặc null nếu không tồn tại.</returns>
        public string GetCookie(string key)
        {
            return _httpContextAccessor.HttpContext.Request.Cookies[key];
        }

        /// <summary>
        /// Xóa một cookie.
        /// </summary>
        /// <param name="key">Tên của cookie.</param>
        public void DeleteCookie(string key)
        {
            _httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
