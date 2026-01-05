using System;

namespace CSharpCodingChallenge
{
    internal class Day74_MajorityElement
    {
        public void FindMajority()
        {
            int[] numbers = { 2, 2, 1, 2, 3, 2, 2 };

            int candidate = numbers[0];
            int count = 1;

            // Step 1: Find candidate
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;

                    if (count == 0)
                    {
                        candidate = numbers[i];
                        count = 1;
                    }
                }
            }

            // Step 2: Verify candidate
            int freq = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == candidate)
                {
                    freq++;
                }
            }

            if (freq > numbers.Length / 2)
            {
                Console.WriteLine("Majority element is: " + candidate);
            }
            else
            {
                Console.WriteLine("No majority element exists.");
            }
        }
    }
}
