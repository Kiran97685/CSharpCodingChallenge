using System;

namespace CSharpCodingChallenge
{
    internal class Day11_ArrayUnique
    {
        public void PrintUnique()
        {
            int[] numbers = { 2, 3, 2, 4, 5, 3, 6, 4 };

            Console.WriteLine("Unique elements are:");

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
