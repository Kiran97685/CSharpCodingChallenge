using System;
public class ArrayMerge
{
    public void MergeArrays()
    {
        int[] arr1 = { 1, 2, 3, 4 };
        int[] arr2 = { 5, 6, 7, 8 };

        int[] merged = new int[arr1.Length + arr2.Length];

        int index = 0;

        // Copy first array
        for (int i = 0; i < arr1.Length; i++)
        {
            merged[index] = arr1[i];
            index++;
        }

        // Copy second array
        for (int i = 0; i < arr2.Length; i++)
        {
            merged[index] = arr2[i];
            index++;
        }

        Console.WriteLine("Merged Array:");
        for (int i = 0; i < merged.Length; i++)
        {
            Console.Write(merged[i] + " ");
        }
    }
}
