using System;
using HackerRank.Program.Domains.Algorithms;
using HackerRank.Program.Domains;
using HackerRank.Program.Domains.Algorithms.WarmupChallenges;

namespace HackerRank.Program
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
                Console.WriteLine("HackerRank.");
                IChallenge challenge = DomainChooser();
                Console.WriteLine(challenge.Instructions());
                challenge.Input();
                Console.WriteLine(challenge.Output());

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (ChallengeException e)
            {
                Console.WriteLine("Please choose a valid challenge.\n" +
                    "See valid challenge in https://www.hackerrank.com/domains");
                Console.Error.WriteLine(e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Please choose a valid domains.\n" +
                    "See valid challenge in https://www.hackerrank.com/domains");
                Console.Error.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number.");
                Console.Error.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Ask the user for a number representing the Domain he/she wants.
        /// </summary>
        /// <returns>An IChallenge implemetation representing a supported challenge</returns>
        public static IChallenge DomainChooser()
        {
            int domain;
            Console.WriteLine("Domains:" +
                "\n\t 0.- Algorithms" +
                "\n\t More supported domains in the future.");
            Console.WriteLine("\nPlease enter the number of the HackerRank Domain: ");
            domain = Convert.ToInt32(Console.ReadLine());

            switch ((Domain)domain)
            {
                case Domain.ALGORITHMS: return AlgorithmsChallengeChooser();  
                case Domain.ARTIFICIAL_INTELLIGENCE:
                case Domain.DATABASES:
                case Domain.DATA_STRUCTURES:
                case Domain.DISTRIBUTED_SYSTEMS:
                case Domain.FUNCTIONAL_PROGRAMMING:
                case Domain.MATHEMATICS:
                case Domain.REGEX:
                case Domain.SECURITY:
                default: throw new DomainException();
            }
        }

        /// <summary>
        /// Ask the user for a number representing the challenge he/she wants.
        /// </summary>
        /// <returns>An IChallenge implemetation representing a supported challenge</returns>
        public static IChallenge AlgorithmsChallengeChooser()
        {
            int challenge;
            Console.WriteLine("Challenges:" +
                "\n\t 0.- Warmup" +
                "\n\t More supperted Challenges in the future");
            Console.WriteLine("\nPlease enter the number of the HackerRank Challenge: ");
            challenge = Convert.ToInt32(Console.ReadLine());

            switch ((AlgorithmsChallenge)challenge)
            {
                case AlgorithmsChallenge.WARMUP: return WarmupChallengeChooser();
                case AlgorithmsChallenge.BIT_MANIPULATION:
                case AlgorithmsChallenge.DYNAMIC_PROGRAMMING:
                case AlgorithmsChallenge.GAME_THEORY:
                case AlgorithmsChallenge.GRAPH_THEORY:
                case AlgorithmsChallenge.GREEDY:
                case AlgorithmsChallenge.IMPLEMENTATION:
                case AlgorithmsChallenge.NP_COMPLETE:
                case AlgorithmsChallenge.SEARCH:
                case AlgorithmsChallenge.SORTING:
                case AlgorithmsChallenge.STRINGS:
                default: throw new ChallengeException();
            }
        }

        /// <summary>
        /// Ask the user for a number representing the Challenge he/she wants.
        /// </summary>
        /// <returns>An IChallenge implemetation representing a supported challenge</returns>
        public static IChallenge WarmupChallengeChooser()
        {
            int challenge;
            Console.WriteLine("Challenges:" +
                "\n\t 0.- Solve Me First" +
                "\n\t 1.- Simple Array Sum" +
                "\n\t 2.- A Very Big Sum" +
                "\n\t More supperted Challenges in the future");
            Console.WriteLine("\nPlease enter the number of the HackerRank Challenge: ");
            challenge = Convert.ToInt32(Console.ReadLine());

            switch ((WarmupChallenge)challenge)
            {
                case WarmupChallenge.SOLVE_ME_FIRST: return new SolveMeFirst();
                case WarmupChallenge.SIMPLE_ARRAY_SUM: return new SimpleArraySum();
                case WarmupChallenge.A_VERY_BIG_SUM: return new AVeryBigSum();
                case WarmupChallenge.DIAGONAL_DIFFERENCE:
                case WarmupChallenge.PLUS_MINUS:
                case WarmupChallenge.STAIRCASE:
                case WarmupChallenge.TIME_CONVERSION:
                default: throw new ChallengeException();
            }
        }
    }
}
