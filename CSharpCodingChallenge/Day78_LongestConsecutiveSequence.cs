using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day78_LongestConsecutiveSequence
    {
        public void FindLongestSequence()
        {
            int[] numbers = { 100, 4, 200, 1, 3, 2 };

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                set.Add(numbers[i]);
            }

            int longest = 0;

            foreach (int num in set)
            {
                // Start only if it's the beginning of a sequence
                if (!set.Contains(num - 1))
                {
                    int current = num;
                    int length = 1;

                    while (set.Contains(current + 1))
                    {
                        current++;
                        length++;
                    }

                    if (length > longest)
                    {
                        longest = length;
                    }
                }
            }

            Console.WriteLine("Longest consecutive sequence length: " + longest);
        }
    }
}
