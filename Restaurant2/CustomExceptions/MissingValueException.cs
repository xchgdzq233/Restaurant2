using System;

namespace Restaurant2
{
    public class MissingValueException : Exception
    {
        public MissingValueException()
        {
        }

        public MissingValueException(string message)
            : base(message)
        {
        }

        public MissingValueException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    
}
