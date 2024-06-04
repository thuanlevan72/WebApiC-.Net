namespace ApiApp.Controllers.BaseResponse
{
    public class BaseHttpResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }
        public DateTime Timestamp { get; set; }


        public BaseHttpResponse()
        {
            Timestamp = DateTime.UtcNow;
        }

        public BaseHttpResponse(bool success, string message, T data, int statusCode, List<string> errors = null)
        {
            Success = success;
            Message = message;
            Data = data;
            StatusCode = statusCode;
            Errors = errors ?? new List<string>();
            Timestamp = DateTime.UtcNow;
        }

        public static BaseHttpResponse<T> CreateSuccessResponse(T data, string message = "Request was successful.", int statusCode = 200)
        {
            return new BaseHttpResponse<T>(true, message, data, statusCode);
        }

       

        public static BaseHttpResponse<T> CreateErrorResponse(string message, int statusCode = 400, List<string> errors = null)
        {
            return new BaseHttpResponse<T>(false, message, default, statusCode, errors);
        }

        public static BaseHttpResponse<T> CreateErrorResponse(string message, int statusCode, string error)
        {
            return new BaseHttpResponse<T>(false, message, default, statusCode, new List<string> { error });
        }
    }
}
