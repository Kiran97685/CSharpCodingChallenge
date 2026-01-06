using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day75_AlternatePosNeg
    {
        public void Rearrange()
        {
            int[] numbers = { 3, -2, 5, -1, -6, 4, -3 };

            List<int> positives = new List<int>();
            List<int> negatives = new List<int>();

            // Separate positives and negatives
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                    positives.Add(numbers[i]);
                else
                    negatives.Add(numbers[i]);
            }

            int p = 0, n = 0;
            int[] result = new int[numbers.Length];
            bool placePositive = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (placePositive && p < positives.Count)
                {
                    result[i] = positives[p++];
                }
                else if (!placePositive && n < negatives.Count)
                {
                    result[i] = negatives[n++];
                }
                else if (p < positives.Count)
                {
                    result[i] = positives[p++];
                }
                else
                {
                    result[i] = negatives[n++];
                }

                placePositive = !placePositive;
            }

            Console.WriteLine("Array after rearranging alternately:");

            foreach (int v in result)
            {
                Console.Write(v + " ");
            }
        }
    }
}
