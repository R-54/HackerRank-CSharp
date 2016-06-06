using System;

namespace HackerRank
{
    /// <summary>
    /// Class that represents the challenge "Solve Me First" in HackerRank.
    /// The challenge: Add two numbers given in stdin and print the result in stdout.
    /// </summary>
    public class SolveMeFirst : IChallenge
    {
        /// <summary>
        /// Represents a number to make an addition operation.
        /// </summary>
        private double a;
        /// <summary>
        /// Represents a number to make an addition operation.
        /// </summary>
        private double b;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public SolveMeFirst()
        {
            a = 0;
            b = 0;
        }

        /// <summary>
        /// Makes an addition operation with two given doubles (a + b).
        /// </summary>
        /// <param name="a">First double in the operation.</param>
        /// <param name="b">Second double in the operation.</param>
        /// <returns>The sum of two doubles (A double).</returns>
        private double Sum(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// The sum of two numbers.
        /// </summary>
        /// <returns>A string representing the sum of two doubles.</returns>
        public string Output()
        {
            return Convert.ToString(Sum(a, b) );
        }


        /// <summary>
        /// Ask for the a and b doubles to make the addition operation.
        /// </summary>
        public void Input()
        {
            a = Convert.ToInt64(Console.ReadLine());
            b = Convert.ToInt64(Console.ReadLine());
        }

        /// <summary>
        /// Intructions of this challenge..
        /// </summary>
        /// <returns>A string representing the instructions of this challenge.</returns>
        public string Instructions()
        {
            return "Enter 2 numbers to make an addition operation: a + b.\n" +
                "See https://www.hackerrank.com/challenges/solve-me-first for details.";
        }
    }
}
