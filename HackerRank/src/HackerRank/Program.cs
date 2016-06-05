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

            ExitMessage();
        }

        /// <summary>
        /// Writes an exit message to the stdout and waits for the user to click any key.
        /// </summary>
        public static void ExitMessage()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
