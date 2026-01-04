using System;

namespace CSharpCodingChallenge
{
    internal class Day73_RotateArrayRight
    {
        public void RotateRight()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int k = 2;

            int n = numbers.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newIndex = (i + k) % n;
                result[newIndex] = numbers[i];
            }

            Console.WriteLine("Array after rotating right by " + k + " steps:");

            foreach (int val in result)
            {
                Console.Write(val + " ");
            }
        }
    }
}
