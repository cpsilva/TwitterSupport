using System;

namespace TwitterSupport.CrossCutting.Values
{
    public class ServiceException : Exception
    {
        public ServiceException(string message) : base(message)
        { }
    }
}