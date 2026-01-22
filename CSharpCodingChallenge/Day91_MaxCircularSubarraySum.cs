using System;

namespace CSharpCodingChallenge
{
    internal class Day91_MaxCircularSubarraySum
    {
        public void FindMaxCircularSum()
        {
            int[] numbers = { 8, -1, 3, 4 };

            // Step 1: Normal maximum subarray sum
            int maxNormal = Kadane(numbers);

            // If all elements are negative
            if (maxNormal < 0)
            {
                Console.WriteLine("Maximum circular subarray sum: " + maxNormal);
                return;
            }

            // Step 2: Find total sum and invert array
            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
                numbers[i] = -numbers[i];
            }

            // Step 3: Find maximum sum of inverted array
            int maxInverted = Kadane(numbers);

            // Step 4: Circular sum
            int maxCircular = totalSum + maxInverted;

            // Step 5: Final result
            int result = Math.Max(maxNormal, maxCircular);

            Console.WriteLine("Maximum circular subarray sum: " + result);
        }

        private int Kadane(int[] arr)
        {
            int maxEndingHere = arr[0];
            int maxSoFar = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                maxEndingHere = Math.Max(arr[i], maxEndingHere + arr[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
}
