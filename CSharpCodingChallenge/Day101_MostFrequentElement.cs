using System;

namespace CSharpCodingChallenge
{
    internal class Day101_MostFrequentElement
    {
        public void FindMostFrequentElement()
        {
            int[] numbers = { 1, 3, 2, 3, 4, 3, 2 };

            if (numbers.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return;
            }

            int maxCount = 0;
            int mostFrequent = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = numbers[i];
                }
            }

            Console.WriteLine("Most frequent element: " + mostFrequent);
        }
    }