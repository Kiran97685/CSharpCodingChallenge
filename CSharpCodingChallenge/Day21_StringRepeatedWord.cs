using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day23_StringMostRepeatedWord
    {
        public void FindMostRepeatedWord()
        {
            string sentence = "learning CSharp is fun and learning coding improves confidence in coding";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // Count each word (case-insensitive)
            foreach (string word in words)
            {
                string key = word.ToLower();

                if (wordCount.ContainsKey(key))
                    wordCount[key]++;
                else
                    wordCount[key] = 1;
            }

            // Find word with max count
            string mostRepeated = "";
            int maxCount = 0;

            foreach (var item in wordCount)
            {
                if (item.Value > maxCount)
                {
                    mostRepeated = item.Key;
                    maxCount = item.Value;
                }
            }

            Console.WriteLine("Most repeated word: " + mostRepeated);
            Console.WriteLine("Repeated count: " + maxCount);
        }
    }
}
