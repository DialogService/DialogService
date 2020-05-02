using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DialogService
{
    public class NoPlatformException : Exception
    {
        public NoPlatformException()
        {
        }

        public NoPlatformException(string message) : base(message)
        {
        }

        public NoPlatformException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoPlatformException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
