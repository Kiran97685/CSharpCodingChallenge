using System;

public class ArrayEvenOdd
{
    public void CountEvenOdd()
    {
        int[] numbers = { 3, 6, 9, 12, 15, 18, 21 };

        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine("Total Even numbers: " + evenCount);
        Console.WriteLine("Total Odd numbers: " + oddCount);
    }
}
