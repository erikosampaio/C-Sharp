using System;
using System.Runtime.Serialization;

namespace Account_Exception
{
    [Serializable]
    internal class DomaintException : Exception
    {
        public DomaintException()
        {
        }

        public DomaintException(string message) : base(message)
        {
        }

        public DomaintException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DomaintException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}