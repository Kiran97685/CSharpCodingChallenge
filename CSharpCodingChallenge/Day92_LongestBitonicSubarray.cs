using System;

namespace CSharpCodingChallenge
{
    internal class Day92_LongestBitonicSubarray
    {
        public void FindLongestBitonic()
        {
            int[] arr = { 12, 4, 78, 90, 45, 23 };

            int n = arr.Length;
            int[] inc = new int[n];
            int[] dec = new int[n];

            // Increasing subarray lengths
            inc[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                    inc[i] = inc[i - 1] + 1;
                else
                    inc[i] = 1;
            }

            // Decreasing subarray lengths
            dec[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                    dec[i] = dec[i + 1] + 1;
                else
                    dec[i] = 1;
            }

            int maxLength = 1;
            for (int i = 0; i < n; i++)
            {
                maxLength = Math.Max(maxLength, inc[i] + dec[i] - 1);
            }

            Console.WriteLine("Longest Bitonic Subarray Length: " + maxLength);
        }
    }
}
