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
        public void Warmup(WarmupChallenge challenge)
        {
            switch (challenge)
            {
                case WarmupChallenge.SOLVEMEFIRST:
                    SolveMeFirst smf = new SolveMeFirst();
                    InputAndOutputHelper(smf);
                    break;

                default:
                    Console.WriteLine("Select a valid challenge (See valid challenge " +
                        "in https://www.hackerrank.com/domains/algorithms/warmup");
                    break;
            }
        }

        /// <summary>
        /// Helper method that makes me write less code.
        /// <remarks>Gets the input (stdin) and send the output of the challenges (stdout).</remarks>
        /// </summary>
        /// <param name="challenge">A challenge to take input and send output from.</param>
        private void InputAndOutputHelper(IChallenge challenge)
        {
            Console.WriteLine(challenge.Instructions());
            Console.WriteLine("Input: ");
            challenge.Input();
            Console.WriteLine("Output: {0}", challenge.Output());
        }
    }
}
