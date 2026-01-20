using System;

namespace CSharpCodingChallenge
{
    internal class Day89_RemoveDuplicatesSortedArray
    {
        public void RemoveDuplicates()
        {
            int[] numbers = { 1, 1, 2, 2, 3, 4, 4 };

            int uniqueIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[uniqueIndex])
                {
                    uniqueIndex++;
                    numbers[uniqueIndex] = numbers[i];
                }
            }

            int uniqueCount = uniqueIndex + 1;

            Console.WriteLine("Unique elements count: " + uniqueCount);
            Console.WriteLine("Array after removing duplicates:");

            for (int i = 0; i < uniqueCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
