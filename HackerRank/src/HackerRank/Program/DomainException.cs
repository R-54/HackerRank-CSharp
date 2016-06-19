using System;

namespace HackerRank.Program
{
    /// <summary>
    /// Exception that is throw when the user select a not supported or invalid domain.
    /// </summary>
    public class DomainException : Exception
    {
        public DomainException() { }

        public DomainException(string message) : base(message){ }

        public DomainException(string message, Exception inner) : base(message, inner){ }
    }
}
