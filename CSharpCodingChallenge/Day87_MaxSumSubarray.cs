using System;

namespace CSharpCodingChallenge
{
    internal class Day87_MaxSumSubarray
    {
        public void FindMaxSum()
        {
            int[] numbers = { 2, 1, 5, 1, 3, 2 };
            int k = 3;

            int windowSum = 0;
            int maxSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                windowSum += numbers[i];

                if (i >= k - 1)
                {
                    if (windowSum > maxSum)
                    {
                        maxSum = windowSum;
                    }
                    windowSum -= numbers[i - (k - 1)];
                }
            }

            Console.WriteLine("Maximum sum of subarray size " + k + " is: " + maxSum);
        }
    }
}
