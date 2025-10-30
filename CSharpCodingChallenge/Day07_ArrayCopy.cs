using System;

public class ArrayCopy
{
    public void CopyArray()
    {
        int[] source = { 10, 20, 30, 40, 50 };
        int[] destination = new int[source.Length];

        for (int i = 0; i < source.Length; i++)
        {
            destination[i] = source[i];
        }

        Console.WriteLine("Copied array elements:");
        for (int i = 0; i < destination.Length; i++)
        {
            Console.Write(destination[i] + " ");
        }
    }
}
