using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day84_NextGreaterElement
    {
        public void FindNextGreater()
        {
            int[] numbers = { 4, 5, 2, 25 };
            Stack<int> stack = new Stack<int>();

            int[] result = new int[numbers.Length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= numbers[i])
                {
                    stack.Pop();
                }

                result[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(numbers[i]);
            }

            Console.WriteLine("Next Greater Elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " -> " + result[i]);
            }
        }
    }
}
