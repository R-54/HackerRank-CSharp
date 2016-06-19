using System.Numerics;
using System;

namespace HackerRank.Program.Domains.Algorithms.WarmupChallenges
{
    /// <summary>
    /// Represents the "A Very Big Sum" challenge of the HackerRank web page.
    /// </summary>
    public class AVeryBigSum : IChallenge
    {
        /// <summary>
        /// The length of the array.
        /// </summary>
        private int arrayLength;
        /// <summary>
        /// An array with the numbers to be added.
        /// </summary>
        private string[] array;
        /// <summary>
        /// The big integer / The result of the sum.
        /// </summary>
        private BigInteger bigInt;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public AVeryBigSum()
        {
            // Default Constructor.
        }

        /// <summary>
        /// The output of this challenge.
        /// </summary>
        /// <returns>A string representing the big sum of arrays.</returns>
        public string Output()
        {
            foreach (string element in array)
            {
                bigInt += BigInteger.Parse(element);
            }
            return Convert.ToString(bigInt);
        }

        /// <summary>
        /// The input of this challenge. First line is a number representing the array length
        /// and the second line are the N space-separed numbers to be added.
        /// </summary>
        public void Input()
        {
            arrayLength = Convert.ToInt32(Console.ReadLine());
            array = Console.ReadLine().Split( );
        }

        /// <summary>
        /// The instructions of this challenge.
        /// </summary>
        /// <returns>A string representing the instructions of this challenge.</returns>
        public string Instructions()
        {
            return "Given an array of integers print the sum of all the numbers in the array (Really big numbers)." +
                "\nFirst line: The array length." +
                "\nSecond line: The N space-separed numbers to be added." +
                "\nSee https://www.hackerrank.com/challenges/a-very-big-sum for details.";
        }
    }
}
