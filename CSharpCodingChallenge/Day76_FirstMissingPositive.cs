using System;

namespace CSharpCodingChallenge
{
    internal class Day76_FirstMissingPositive
    {
        public void FindMissing()
        {
            int[] numbers = { 3, 4, -1, 1 };

            int n = numbers.Length;

            for (int i = 0; i < n; i++)
            {
                while (numbers[i] > 0 && numbers[i] <= n &&
                       numbers[numbers[i] - 1] != numbers[i])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[temp - 1];
                    numbers[temp - 1] = temp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] != i + 1)
                {
                    Console.WriteLine("First missing positive number is: " + (i + 1));
                    return;
                }
            }

            Console.WriteLine("First missing positive number is: " + (n + 1));
        }
    }
}
