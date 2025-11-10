using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day18_StringDuplicateWords
    {
        public void FindDuplicateWords()
        {
            string sentence = "Welcome to CSharp and welcome to coding in csharp";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Count words (case-insensitive)
            foreach (string w in words)
            {
                string key = w.ToLower();   // normalize case

                if (wordCount.ContainsKey(key))
                    wordCount[key]++;
                else
                    wordCount[key] = 1;
            }

            Console.WriteLine("Duplicate words:");

            bool hasDuplicates = false;

            foreach (var item in wordCount)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(item.Key + " → " + item.Value);
                    hasDuplicates = true;
                }
            }

            if (!hasDuplicates)
            {
                Console.WriteLine("No duplicate words found.");
            }
        }
    }
}
