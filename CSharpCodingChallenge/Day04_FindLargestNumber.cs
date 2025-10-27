using System;

public class ArrayMax
{
    public void DisplayMax()
    {
        int[] numbers = { 12, 45, 67, 23, 89, 34 };
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Largest number in the array: " + max);
    }
}
