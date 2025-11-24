using System;

namespace CSharpCodingChallenge
{
    internal class Day32_DoubleArrayStats
    {
        public void CalculateStats()
        {
            double[] numbers = { 12.5, 7.3, 9.8, 15.2, 4.6, 10.0 };

            double sum = 0;
            double max = numbers[0];
            double min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];

                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }

            double average = sum / numbers.Length;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
        }
    }
}
