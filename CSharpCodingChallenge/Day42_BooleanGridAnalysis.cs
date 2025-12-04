using System;

namespace CSharpCodingChallenge
{
    internal class Day42_BooleanGridAnalysis
    {
        public void AnalyzeGrid()
        {
            // 2D Boolean Array (Grid)
            bool[,] grid = new bool[,]
            {
                { true, false, true, true },
                { false, true, false, false },
                { true, true, true, false },
                { false, false, true, true }
            };

            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            Console.WriteLine("Grid Active Cell Count Per Row:");

            // Count TRUE in each row
            for (int i = 0; i < rows; i++)
            {
                int activeCount = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i, j])
                        activeCount++;
                }
                Console.WriteLine($"Row {i}: {activeCount} active cells");
            }

            Console.WriteLine("\nGrid Active Cell Count Per Column:");

            // Count TRUE in each column
            for (int j = 0; j < cols; j++)
            {
                int activeCount = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (grid[i, j])
                        activeCount++;
                }
                Console.WriteLine($"Column {j}: {activeCount} active cells");
            }
        }
    }
}
