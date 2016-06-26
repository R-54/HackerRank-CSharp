using System;

namespace HackerRank.Program.Domains.Algorithms.WarmupChallenges
{
    public class DiagonalDifference : IChallenge
    {
        private int matrixSize;
        private int[] matrixValues;

        public DiagonalDifference()
        {
            // Default constructor.
        }

        public string Instructions()
        {
            return "Given a square matrix of size N x N, calculate the " +
            "absolute difference between the sums of its diagonals." +
            "\nFirst line: An integer representing the size of the matrix." +
            "\nNext lines: The matrix with space separed values." +
            "\nExample: \n3 \n11 2 4 \n4 5 6 \n10 8 -12";
        }

        public void Input()
        {
            matrixSize = Console.ReadLine();
            int totalMatrixSize = matrixSize * matrixSize;
            matrixValues = new int[totalMatrixSize];
            
            string aux = Console.ReadLine();
            for(int i = 0; i < matrixSize - 1; ++i)
            {
                aux += String.Format(" {0}", Console.ReadLine()
            }

            string[] auxArray = new string[totalMatrixSize];
            auxArray = aux.Split(" ");

            for(int i = 0; i < totalMatrixSize; ++i)
            {
                matrixValues[i] = Convert.ToInt32(auxArray[i] );
            }

            // TODO.
        }

        public string Output()
        {
            return null;
        }
    }   
}