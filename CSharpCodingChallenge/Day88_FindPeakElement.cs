using System;

namespace CSharpCodingChallenge
{
    internal class Day88_FindPeakElement
    {
        public void FindPeak()
        {
            int[] numbers = { 1, 3, 20, 4, 1, 0 };

            int peakIndex = FindPeakIndex(numbers);

            Console.WriteLine("Peak element is: " + numbers[peakIndex]);
            Console.WriteLine("Peak index is: " + peakIndex);
        }

        private int FindPeakIndex(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                bool leftOk = (mid == 0 || arr[mid] >= arr[mid - 1]);
                bool rightOk = (mid == arr.Length - 1 || arr[mid] >= arr[mid + 1]);

                if (leftOk && rightOk)
                    return mid;

                if (mid > 0 && arr[mid - 1] > arr[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return -1;
        }
    }
}
