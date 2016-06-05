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
            Algorithms alg = new Algorithms();
            alg.Warmup(WarmupChallenge.SOLVEMEFIRST);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
