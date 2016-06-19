using System;

namespace HackerRank.Program
{
    /// <summary>
    /// Exception that is throw when the user request a not avaible challenge.
    /// </summary>
    public class ChallengeException : Exception
    {
        public ChallengeException() { }

        public ChallengeException(string message) : base(message){ }

        public ChallengeException(string message, Exception inner) : base(message, inner){ }
    }
}
