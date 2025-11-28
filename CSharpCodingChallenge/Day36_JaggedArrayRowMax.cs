using System;

namespace CSharpCodingChallenge
{
    internal class Day36_JaggedArrayRowMax
    {
        public void FindRowWithMaxSum()
        {
            // Jagged array (array of arrays with different lengths)
            int[][] data = new int[][]
            {
                new int[] { 4, 2, 7 },
                new int[] { 10, 1 },
                new int[] { 3, 5, 6, 2 },
                new int[] { 9, 8 }
            };

            int maxSum = int.MinValue;
            int maxRowIndex = -1;

            for (int i = 0; i < data.Length; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < data[i].Length; j++)
                {
                    rowSum += data[i][j];
                }

                Console.WriteLine($"Sum of Row {i}: {rowSum}");

                if (rowSum > maxSum)
                {
                    maxSum = rowSum;
                    maxRowIndex = i;
                }
            }

            Console.WriteLine($"\nRow with the highest sum: Row {maxRowIndex}");
            Console.WriteLine("Highest Sum: " + maxSum);
        }
    }
}
