using System;

namespace CSharpCodingChallenge
{
    internal class Day63_RotateMatrix
    {
        public void RotateMatrix()
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int n = matrix.GetLength(0);

            // Transpose the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            // Reverse each row
            for (int i = 0; i < n; i++)
            {
                int left = 0, right = n - 1;

                while (left < right)
                {
                    int temp = matrix[i, left];
                    matrix[i, left] = matrix[i, right];
                    matrix[i, right] = temp;

                    left++;
                    right--;
                }
            }

            Console.WriteLine("Matrix after rotating 90 degrees clockwise:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
