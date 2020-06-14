using System;
using System.Net;

namespace NSE.Core.DomainObjects
{
    public class DomainException : Exception
    {

        public DomainException()
        {

        }

        public DomainException(string message)
            : base(message)
        {

        }

        public DomainException(string message, Exception innException)
            : base(message, innException)
        {

        }
    }
}