namespace LCH.MercedesBenz.Api.Models.Application
{
    public class BaseResponse<T>
    {
        public int StatusCode { get; set; }

        public string? Message { get; set; }

        public string? StackTrace { get; set; }

        public T? Result { get; set; }

        public ICollection<T> Results { get; set; } = new List<T>();

        public BaseResponse()
        {
        }

        public BaseResponse(int statusCode)
        {
            StatusCode = statusCode;
        }

        public BaseResponse(int statusCode, string? message)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public BaseResponse(int statusCode, string? message, string? stackTrace)
        {
            StatusCode = statusCode;
            Message = message;
            StackTrace = stackTrace;
        }

        public BaseResponse(int statusCode, T? result)
        {
            StatusCode = statusCode;
            Result = result;
        }

        public BaseResponse(int statusCode, ICollection<T> results)
        {
            StatusCode = statusCode;
            Results = results;
        }

        public BaseResponse(int statusCode, string? message, T result)
        {
            StatusCode = statusCode;
            Message = message;
            Result = result;
        }

        public BaseResponse(int statusCode, string? message, ICollection<T> results)
        {
            StatusCode = statusCode;
            Message = message;
            Results = results;
        }
    }
}
