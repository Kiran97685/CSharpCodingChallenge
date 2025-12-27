using System;

namespace CSharpCodingChallenge
{
    internal class Day65_ArraySpiralOrder
    {
        public void PrintSpiral()
        {
            int[,] matrix =
            {
                { 1,  2,  3,  4 },
                { 5,  6,  7,  8 },
                { 9, 10, 11, 12 },
                { 13,14, 15,16 }
            };

            int top = 0;
            int bottom = matrix.GetLength(0) - 1;
            int left = 0;
            int right = matrix.GetLength(1) - 1;

            while (top <= bottom && left <= right)
            {
                // left → right
                for (int i = left; i <= right; i++)
                    Console.Write(matrix[top, i] + " ");
                top++;

                // top → bottom
                for (int i = top; i <= bottom; i++)
                    Console.Write(matrix[i, right] + " ");
                right--;

                // right → left
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                        Console.Write(matrix[bottom, i] + " ");
                    bottom--;
                }

                // bottom → top
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                        Console.Write(matrix[i, left] + " ");
                    left++;
                }
            }

            Console.WriteLine();
        }
    }
}
