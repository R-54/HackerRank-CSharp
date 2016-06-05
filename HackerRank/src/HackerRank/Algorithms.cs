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
        /// <param name="challenge">A string representing the name of the challenge.</param>
        public void Warmup(string challenge)
        {
            challenge = challenge.ToUpper();
            switch (challenge)
            {
                case "SOLVEMEFIRST":
                    SolveMeFirst smf = new SolveMeFirst();
                    Console.WriteLine(smf.Instructions() );
                    smf.Input();
                    Console.WriteLine(smf.Output() );
                    break;

                default:
                    Console.WriteLine("Select a valid challenge (See valid challenge " +
                        "in https://www.hackerrank.com/domains/algorithms/warmup");
                    break;
            }
        }
    }
}
