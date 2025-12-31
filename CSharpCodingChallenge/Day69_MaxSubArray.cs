using System;

namespace CSharpCodingChallenge
{
    internal class Day69_MaxSubArray
    {
        public void FindMaxSubArray()
        {
            int[] numbers = { -2, 5, -1, 7, -3, 8, -4 };

            int currentSum = numbers[0];
            int maxSum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                // Either extend the previous sum or start new subarray
                currentSum = Math.Max(numbers[i], currentSum + numbers[i]);

                // Track the best seen so far
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            Console.WriteLine("Maximum subarray sum: " + maxSum);
        }
    }
}
