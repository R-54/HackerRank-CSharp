using System;

namespace HackerRank.Program.Domains.Algorithms.WarmupChallenges
{
    /// <summary>
    /// Represents the solution of the Diagonal Difference challenge in HackerRank.
    /// More info abput this challenge on: 
    /// https://www.hackerrank.com/challenges/diagonal-difference?h_r=next-challenge&h_v=zen
    /// </summary>
    public class DiagonalDifference : IChallenge
    {
        /// <summary>
        /// The size of the matrix.
        /// </summary>
        private int matrixSize;
        /// <summary>
        /// The values of the matrix.
        /// </summary>
        private int[,] matrixValues;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DiagonalDifference()
        {
            // Default constructor.
        }

        /// <summary>
        /// The instructions of this challengens.
        /// </summary>
        /// <returns>A string representing the instructions.</returns>
        public string Instructions()
        {
            return "Given a square matrix of size N x N, calculate the " +
            "absolute difference between the sums of its diagonals." +
            "\nFirst line: An integer representing the size of the matrix." +
            "\nNext lines: The matrix with space separed values." +
            "\nExample: \n3 \n11 2 4 \n4 5 6 \n10 8 -12";
        }

        /// <summary>
        /// The input of this challenge.
        /// First line: The size of the matrix.
        /// Nest lines: The rows and columns of the matrix.
        /// </summary>
        public void Input()
        {
            matrixSize = Convert.ToInt32(Console.ReadLine() );
            matrixValues = new int[matrixSize, matrixSize];
            for(int i = 0; i < matrixSize; ++i)
            {
                string[] aux = Console.ReadLine().Split(' ');
                for(int j = 0; j < matrixSize; ++j)
                {
                    matrixValues[i, j] = Convert.ToInt32(aux[j]);
                }
            }
        }

        /// <summary>
        /// The output of this challenge.
        /// </summary>
        /// <returns> A string representing the absolute value of the diagonal difference.</returns>
        public string Output()
        {
            int sum = 0;

            int rowIndex = 0;
            for(int i = 0; i < matrixSize; ++i)
            {
                sum += matrixValues[i, rowIndex++];
            }
            
            rowIndex = matrixSize - 1;
            for(int i = 0; i < matrixSize; ++i)
            {
                sum -= matrixValues[i, rowIndex--];
            }

            return Math.Abs(sum).ToString();
        }
    }   
}