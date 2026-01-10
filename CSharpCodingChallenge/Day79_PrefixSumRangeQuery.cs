using System;

namespace CSharpCodingChallenge
{
    internal class Day79_PrefixSumRangeQuery
    {
        public void RangeSum()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int[] prefixSum = new int[numbers.Length];

            // Build prefix sum array
            prefixSum[0] = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                prefixSum[i] = prefixSum[i - 1] + numbers[i];
            }

            // Range queries
            PrintRangeSum(prefixSum, 1, 3); // 4 + 6 + 8
            PrintRangeSum(prefixSum, 0, 4); // full array
        }

        private void PrintRangeSum(int[] prefix, int left, int right)
        {
            int sum;

            if (left == 0)
                sum = prefix[right];
            else
                sum = prefix[right] - prefix[left - 1];

            Console.WriteLine($"Sum from index {left} to {right} is: {sum}");
        }
    }
}
