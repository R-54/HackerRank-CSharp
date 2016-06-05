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
        /// <value> First double in the addition operation. </value>
        private double a;
        /// <summary>
        /// Represents a number to make an addition operation.
        /// </summary>
        /// <value> Second double in the addition operation. </value>
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
        /// Implementation of the Output methond in IChallenge interface.
        /// </summary>
        /// <returns>A string representing the sum of two doubles.</returns>
        public string Output()
        {
            return Convert.ToString(Sum(a, b) );
        }


        /// <summary>
        /// Implementation of the Input method in IChallenge interface.
        /// <remarks>Ask for the a and b doubles to make the addition operation.</remarks>
        /// </summary>
        /// <exception cref="FormatException">Throw when the user enter an invalid input.</exception>
        public void Input()
        {
            try
            {
                Console.Write("a = ");
                a = Convert.ToInt64(Console.ReadLine());
                Console.Write("b = ");
                b = Convert.ToInt64(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Invalid input. Please try again and enter a valid number.");
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Implementation of the Intructions method in the IChallenge interface.
        /// </summary>
        /// <returns>A string representing the instructions of this challenge.</returns>
        public string Instructions()
        {
            return "Enter 2 numbers to make an addition operation: a + b";
        }
    }
}
