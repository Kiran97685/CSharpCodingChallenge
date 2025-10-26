using System;

public class ArrayExample
{
    public void DisplayArray()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        Console.WriteLine("Elements in the array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}