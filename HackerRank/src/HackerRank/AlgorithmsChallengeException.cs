using System;

namespace HackerRank
{
    /// <summary>
    /// Exception that is throw when the user request a not avaible challenge.
    /// </summary>
    public class AlgorithmsChallengeException : Exception
    {
        public AlgorithmsChallengeException() { }

        public AlgorithmsChallengeException(string message) : base(message){ }

        public AlgorithmsChallengeException(string message, Exception inner) : base(message, inner){ }
    }
}
