using System;

namespace HackerRank.Program.Domains.Algorithms.WarmupChallenges
{
    /// <summary>
    /// Represents the "Simple Array Sum" challenge of the HackerRank web page.
    /// </summary>
    public class SimpleArraySum : IChallenge
    {
        /// <summary>
        /// Represents the length of an array.
        /// </summary>
        private int arrayLength;
        /// <summary>
        /// Represents the user input (Numbers).
        /// </summary>
        private string[] input;
        /// <summary>
        /// Represents the user input converted from string to double.
        /// </summary>
        private double[] elements;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SimpleArraySum()
        {
            // Default constructor.
        }

        /// <summary>
        /// The instructions of this challenge.
        /// </summary>
        /// <returns>A strings representing the instructions of this challenge.</returns>
        public string Instructions()
        {
            return "Given an array of N integers, find the sum of its elements." +
                "\nFirst line: The array length." +
                "\nSecond line: The N space-separed numbers to be added." +
                "\nSee https://www.hackerrank.com/challenges/simple-array-sum for details.";
        }

        /// <summary>
        /// An n number representing the array length and an n space-separed number of 
        /// elements to be added.
        /// </summary>
        public void Input()
        {
            arrayLength = Convert.ToInt32(Console.ReadLine() );
            elements = new double[arrayLength];
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < arrayLength; ++i)
                elements[i] = Convert.ToInt64(input[i] );
        }

        /// <summary>
        /// The sum of N numbers in an array.
        /// </summary>
        /// <returns>The sum of the N numbers in an array.</returns>
        public string Output()
        {
            double result = 0;
            foreach (double i in elements)
                result += i;
            return Convert.ToString(result);
        }
    }
}
