using System;

namespace CSharpCodingChallenge
{
    internal class Day02_SumOfElements
    {
        public void SumOfElements()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            double average = (double)sum / numbers.Length;
            Console.WriteLine("Average of array elements: " + average);

        }
    }
}
