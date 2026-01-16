using System;

namespace CSharpCodingChallenge
{
    internal class Day85_PeakElement
    {
        public void FindPeak()
        {
            int[] numbers = { 1, 3, 20, 4, 1, 0 };

            int n = numbers.Length;

            // Check first element
            if (n == 1 || numbers[0] > numbers[1])
            {
                Console.WriteLine("Peak element is: " + numbers[0]);
                return;
            }

            // Check middle elements
            for (int i = 1; i < n - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine("Peak element is: " + numbers[i]);
                    return;
                }
            }

            // Check last element
            if (numbers[n - 1] > numbers[n - 2])
            {
                Console.WriteLine("Peak element is: " + numbers[n - 1]);
                return;
            }

            Console.WriteLine("No peak element found.");
        }
    }
}
