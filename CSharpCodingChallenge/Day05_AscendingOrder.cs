using System;

public class ArraySort
{
    public void DisplaySortedArray()
    {
        int[] numbers = { 25, 10, 45, 20, 5 };

        Console.WriteLine("Original array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Array.Sort(numbers); // built-in C# method to sort arrays

        Console.WriteLine("\nSorted array (ascending):");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
