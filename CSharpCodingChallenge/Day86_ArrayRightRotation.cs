using System;

namespace CSharpCodingChallenge
{
    internal class Day86_ArrayRightRotation
    {
        public void RotateArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int k = 2;

            int length = numbers.Length;
            k = k % length; // handle large rotations

            Reverse(numbers, 0, length - 1);
            Reverse(numbers, 0, k - 1);
            Reverse(numbers, k, length - 1);

            Console.WriteLine("Array after right rotation:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        private void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
