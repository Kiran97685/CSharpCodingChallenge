using System;

namespace CSharpCodingChallenge
{
    internal class Day93_FirstRepeatingElement
    {
        public void FindFirstRepeating()
        {
            int[] arr = { 10, 5, 3, 4, 3, 5, 6 };

            int minIndex = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        minIndex = Math.Min(minIndex, j);
                        break;
                    }
                }
            }

            if (minIndex == arr.Length)
                Console.WriteLine("No repeating element found");
            else
                Console.WriteLine("First repeating element is: " + arr[minIndex]);
        }
    }
}
