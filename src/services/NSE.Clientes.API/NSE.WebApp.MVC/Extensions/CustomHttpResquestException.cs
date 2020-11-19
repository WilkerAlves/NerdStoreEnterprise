using System;
using System.Net;

namespace NSE.WebApp.MVC.Extensions
{
    public class CustomHttpResquestException : Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpResquestException()
        {
            
        }

        public CustomHttpResquestException(string message, Exception innException)
            : base(message, innException)
        {
            
        }

        public CustomHttpResquestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

    }
}