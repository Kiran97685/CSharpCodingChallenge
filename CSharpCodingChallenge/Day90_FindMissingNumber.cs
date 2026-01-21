using System;

namespace CSharpCodingChallenge
{
    internal class Day90_FindMissingNumber
    {
        public void FindMissing()
        {
            int[] numbers = { 1, 2, 4, 5, 6 };

            int n = numbers.Length + 1;

            int expectedSum = n * (n + 1) / 2;
            int actualSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                actualSum += numbers[i];
            }

            int missingNumber = expectedSum - actualSum;

            Console.WriteLine("Missing number is: " + missingNumber);
        }
    }
}
