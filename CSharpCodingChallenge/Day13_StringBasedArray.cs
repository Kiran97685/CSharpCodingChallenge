using System;

namespace CSharpCodingChallenge
{
    internal class Day13_StringVowels
    {
        public void PrintVowelNames()
        {
            string[] names = { "Amit", "John", "Emma", "Steve", "Ivy", "Bob", "Oliver" };

            Console.WriteLine("Names starting with vowels:");

            for (int i = 0; i < names.Length; i++)
            {
                char first = char.ToLower(names[i][0]);

                if (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u')
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
