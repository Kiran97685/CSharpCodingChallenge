using System;

namespace CSharpCodingChallenge
{
    internal class Day77_KthSmallestQuickSelect
    {
        public void FindKthSmallest()
        {
            int[] numbers = { 7, 10, 4, 3, 20, 15 };
            int k = 3;   // 3rd smallest

            int result = QuickSelect(numbers, 0, numbers.Length - 1, k - 1);

            Console.WriteLine("K-th smallest element is: " + result);
        }

        private int QuickSelect(int[] arr, int left, int right, int k)
        {
            int pivotIndex = Partition(arr, left, right);

            if (pivotIndex == k)
                return arr[pivotIndex];

            if (k < pivotIndex)
                return QuickSelect(arr, left, pivotIndex - 1, k);

            return QuickSelect(arr, pivotIndex + 1, right, k);
        }

        private int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }

            int t = arr[i];
            arr[i] = arr[right];
            arr[right] = t;

            return i;
        }
    }
}
