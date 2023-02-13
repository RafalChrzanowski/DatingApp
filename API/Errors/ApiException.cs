namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statusCode, int message, int details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        public int StatusCode { get; set; }

    public int Message { get; set; }

    public int Details { get; set; }
    }



}