using System;

namespace CSharpCodingChallenge
{
    internal class Day27_HighestVowelWord
    {
        public void FindWordWithMostVowels()
        {
            string sentence = "education improves your understanding significantly";

            string[] words = sentence.Split(' ');

            string highestVowelWord = "";
            int maxVowels = 0;

            for (int i = 0; i < words.Length; i++)
            {
                int vowelCount = 0;

                for (int j = 0; j < words[i].Length; j++)
                {
                    char ch = char.ToLower(words[i][j]);

                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowelCount++;
                    }
                }

                if (vowelCount > maxVowels)
                {
                    maxVowels = vowelCount;
                    highestVowelWord = words[i];
                }
            }

            Console.WriteLine("Sentence: " + sentence);
            Console.WriteLine("Word with highest vowels: " + highestVowelWord);
            Console.WriteLine("Number of vowels: " + maxVowels);
        }
    }
}
