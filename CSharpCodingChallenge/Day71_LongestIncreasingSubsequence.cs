using System;

namespace CSharpCodingChallenge
{
    internal class Day71_LongestIncreasingSubsequence
    {
        public void FindLIS()
        {
            int[] numbers = { 5, 1, 4, 2, 3, 10, 6 };

            int n = numbers.Length;
            int[] dp = new int[n];
            int[] prev = new int[n];

            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                prev[i] = -1;
            }

            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] < numbers[i] && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }

                if (dp[i] > dp[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.Write("Longest Increasing Subsequence: ");

            int k = maxIndex;
            int[] result = new int[dp[maxIndex]];
            int idx = result.Length - 1;

            while (k != -1)
            {
                result[idx--] = numbers[k];
                k = prev[k];
            }

            foreach (int val in result)
            {
                Console.Write(val + " ");
            }

            Console.WriteLine();
        }
    }
}
