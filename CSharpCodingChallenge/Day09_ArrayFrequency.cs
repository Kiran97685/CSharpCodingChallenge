using System;

public class Day09_ArrayFrequency
{
    public void CountFrequency()
    {
        int[] numbers = { 2, 3, 2, 5, 3, 2, 4, 5 };
        bool[] visited = new bool[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (visited[i] == true)
                continue;

            int count = 1;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine(numbers[i] + " occurs " + count + " time(s)");
        }
    }
}
