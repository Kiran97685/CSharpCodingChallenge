using System;

namespace CSharpCodingChallenge
{
    internal class Day93_LongestConsecutiveSubarray
    {
        public void FindLongestConsecutive()
        {
            int[] arr = { 1, 2, 3, 2, 3, 4, 5, 1 };

            int currentLength = 1;
            int maxLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
            }

            Console.WriteLine("Length of longest consecutive subarray: " + maxLength);
        }
    }
}
