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
                Console.WriteLine(challenge.Output() );

                challenge = alg.Warmup(WarmupChallenge.SIMPLEARRAYSUM);
                Console.WriteLine(challenge.Instructions());
                challenge.Input();
                Console.WriteLine(challenge.Output());
            }

            catch (AlgorithmsChallengeException e)
            {
                Console.WriteLine("Please choose a valid challenge.\n" +
                    "See valid challenge in https://www.hackerrank.com/domains/algorithms/warmup");
                Console.Error.WriteLine(e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number.");
                Console.Error.WriteLine(e.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
