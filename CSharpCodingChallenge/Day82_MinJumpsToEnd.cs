using System;

namespace CSharpCodingChallenge
{
    internal class Day82_MinJumpsToEnd
    {
        public void FindMinJumps()
        {
            int[] numbers = { 2, 3, 1, 1, 4 };

            int jumps = 0;
            int currentEnd = 0;
            int farthest = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                farthest = Math.Max(farthest, i + numbers[i]);

                if (i == currentEnd)
                {
                    jumps++;
                    currentEnd = farthest;
                }
            }

            Console.WriteLine("Minimum number of jumps: " + jumps);
        }
    }
}
