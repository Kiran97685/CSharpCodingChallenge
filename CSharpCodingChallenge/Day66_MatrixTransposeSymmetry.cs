using System;

namespace CSharpCodingChallenge
{
    internal class Day66_MatrixTransposeSymmetry
    {
        public void CheckMatrixSymmetry()
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 2, 5, 6 },
                { 3, 6, 9 }
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transpose = new int[cols, rows];

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            // Build transpose
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }

            Console.WriteLine("\nTranspose Matrix:");
            PrintMatrix(transpose);

            // Check symmetry (without bool)
            int mismatch = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] != transpose[i, j])
                    {
                        mismatch++;
                    }
                }
            }

            if (mismatch == 0)
                Console.WriteLine("\nMatrix is Symmetric");
            else
                Console.WriteLine("\nMatrix is NOT Symmetric");
        }

        private void PrintMatrix(int[,] arr)
        {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
