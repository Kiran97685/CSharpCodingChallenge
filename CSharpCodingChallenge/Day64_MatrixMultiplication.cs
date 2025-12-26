using System;

namespace CSharpCodingChallenge
{
    internal class Day64_MatrixMultiplication
    {
        public void MultiplyMatrices()
        {
            int[,] A =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] B =
            {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            };

            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);

            // result matrix
            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < colsA; k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            Console.WriteLine("Matrix Multiplication Result:");

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
