using System;

public class ArraySearch
{
    public void SearchNumber()
    {
        int[] numbers = { 5, 12, 25, 8, 30, 18 };
        int searchValue = 25;
        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchValue)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine(searchValue + " is found in the array.");
        else
            Console.WriteLine(searchValue + " is NOT found in the array.");
    }
}
