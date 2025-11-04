using System;

namespace CSharpCodingChallenge
{
    internal class Day12_ArrayPosNegNumbers
    {
        public void CountPositiveNegative()
        {
            int[] numbers = { -10, 23, -4, 5, -6, 7, -8, 9 };

            int positiveCount = 0;
            int negativeCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    positiveCount++;
                }
                else                 
                {
                    negativeCount++;
                }
            }

            Console.WriteLine("Positive numbers count: " + positiveCount);
            Console.WriteLine("Negative numbers count: " + negativeCount);
        }
    }
}

