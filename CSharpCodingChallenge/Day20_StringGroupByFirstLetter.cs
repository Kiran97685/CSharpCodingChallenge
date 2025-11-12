using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day22_StringGroupByFirstLetter
    {
        public void GroupWords()
        {
            string sentence = "coding challenges create confidence and curiosity in coders";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            // Dictionary → key = first letter, value = list of words
            Dictionary<char, List<string>> groups = new Dictionary<char, List<string>>();

            foreach (string word in words)
            {
                char first = char.ToLower(word[0]);   // normalize

                if (!groups.ContainsKey(first))
                {
                    groups[first] = new List<string>();
                }

                groups[first].Add(word);
            }

            Console.WriteLine("Words grouped by first letter:\n");

            foreach (var item in groups)
            {
                Console.WriteLine($"Letter '{item.Key}' → Count: {item.Value.Count}");
                foreach (var w in item.Value)
                {
                    Console.WriteLine("   " + w);
                }
                Console.WriteLine();
            }
        }
    }
}
