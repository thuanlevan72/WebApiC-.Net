using Newtonsoft.Json;

namespace ApiApp.Helpers
{
    public class SessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Thêm một giá trị vào session.
        /// </summary>
        /// <typeparam name="T">Kiểu dữ liệu của giá trị.</typeparam>
        /// <param name="key">Tên của session.</param>
        /// <param name="value">Giá trị của session.</param>
        public void SetSession<T>(string key, T value)
        {
            var sessionValue = JsonConvert.SerializeObject(value);
            _httpContextAccessor.HttpContext.Session.SetString(key, sessionValue);
        }

        /// <summary>
        /// Lấy giá trị từ session.
        /// </summary>
        /// <typeparam name="T">Kiểu dữ liệu của giá trị.</typeparam>
        /// <param name="key">Tên của session.</param>
        /// <returns>Giá trị của session hoặc mặc định nếu không tồn tại.</returns>
        public T GetSession<T>(string key)
        {
            var sessionValue = _httpContextAccessor.HttpContext.Session.GetString(key);
            return sessionValue == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionValue);
        }

        /// <summary>
        /// Xóa một session.
        /// </summary>
        /// <param name="key">Tên của session.</param>
        public void RemoveSession(string key)
        {
            _httpContextAccessor.HttpContext.Session.Remove(key);
        }
    }
}
