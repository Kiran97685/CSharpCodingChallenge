using System;

namespace CSharpCodingChallenge
{
    internal class Day72_CompressArray
    {
        public void Compress()
        {
            int[] numbers = { 1, 1, 2, 2, 2, 3, 3, 4, 4, 4, 5 };

            int[] compressed = new int[numbers.Length];
            int index = 0;

            compressed[index] = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[i - 1])
                {
                    index++;
                    compressed[index] = numbers[i];
                }
            }

            Console.WriteLine("Compressed Array:");

            for (int i = 0; i <= index; i++)
            {
                Console.Write(compressed[i] + " ");
            }
        }
    }
}
