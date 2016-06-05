using System;

namespace HackerRank
{
    /// <summary>
    /// Main class of this program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method of this program.
        /// </summary>
        /// <param name="args">Arguments passed to the program.</param>
        public static void Main(string[] args)
        {
            try
            {
                Algorithms alg = new Algorithms();
                IChallenge challenge = alg.Warmup(WarmupChallenge.SOLVEMEFIRST);
                Console.WriteLine(challenge.Instructions() );
                challenge.Input();
                Console.WriteLine("Output: {0}", challenge.Output() );
            }

            catch (AlgorithmsChallengeException e)
            {
                Console.WriteLine("Please choose a valid challenge. See valid challenge " +
                    "in https://www.hackerrank.com/domains/algorithms/warmup");
            }

            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
