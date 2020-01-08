using System.Net;

namespace Common.Core
{
    public class ApiResponse<T>  
    {       

        public T Result { get; set; }
        public bool ErrorOccurred { get; set; }
        public string ErrorMessage { get; set; }  
        public string ResponseText { get; set; }       
        public HttpStatusCode StatusCode { get; set; }
    }
}
