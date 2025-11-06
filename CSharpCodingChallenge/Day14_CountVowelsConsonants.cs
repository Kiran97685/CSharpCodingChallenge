using System;

namespace CSharpCodingChallenge
{
    internal class Day13_StringVowelConsonant
    {
        public void CountVowelsConsonants()
        {
            string input = "Hello World";
            int vowelCount = 0;
            int consonantCount = 0;

            string vowels = "aeiouAEIOU";

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    if (vowels.Contains(input[i]))
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }

            Console.WriteLine("Vowels count: " + vowelCount);
            Console.WriteLine("Consonants count: " + consonantCount);
        }
    }
}
