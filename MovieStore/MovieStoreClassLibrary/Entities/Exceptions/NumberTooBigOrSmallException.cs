using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreClassLibrary.Entities.Exceptions
{
    public class NumberTooBigOrSmallException : Exception
    {
        public NumberTooBigOrSmallException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
