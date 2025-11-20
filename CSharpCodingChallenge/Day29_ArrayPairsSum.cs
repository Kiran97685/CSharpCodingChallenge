using System;

namespace CSharpCodingChallenge
{
    internal class Day29_ArrayPairsSum
    {
        public void FindPairsWithSum()
        {
            int[] numbers = { 2, 4, 3, 5, 7, 8, 1 };
            int targetSum = 9;

            Console.WriteLine("Pairs with sum " + targetSum + ":");

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == targetSum)
                    {
                        Console.WriteLine(numbers[i] + " + " + numbers[j]);
                    }
                }
            }
        }
    }
}
