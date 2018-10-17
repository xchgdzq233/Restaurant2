using System;

namespace Restaurant2
{
    public class InvalidValueException : Exception
    {
        public InvalidValueException()
        {
        }

        public InvalidValueException(string message)
            : base(message)
        {
        }

        public InvalidValueException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    
}
