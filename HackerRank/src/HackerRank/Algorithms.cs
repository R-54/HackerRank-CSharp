using System;
namespace HackerRank
{
    /// <summary>
    /// Class representing the Algorithms Domain of the HackerRank web page.
    /// </summary>
    public class Algorithms
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Algorithms()
        {
            // Default constructor.
        }

        /// <summary>
        /// Warmup challenge of the Algorithms domain.
        /// </summary>
        /// <param name="challenge">An enum representing the name of the challenge.</param>
        public IChallenge Warmup(WarmupChallenge challenge)
        {
            switch (challenge)
            {
                case WarmupChallenge.SOLVEMEFIRST: return new SolveMeFirst();
                case WarmupChallenge.SIMPLEARRAYSUM: return new SimpleArraySum();
                default: throw new AlgorithmsChallengeException();
            }
        }
    }
}
