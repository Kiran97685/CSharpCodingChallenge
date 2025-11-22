using System;

namespace CSharpCodingChallenge
{
    internal class Day30_StringSubstringSearch
    {
        public void FindStringsWithSubstring()
        {
            string[] words = { "apple", "application", "banana", "grape", "pineapple", "appetite" };
            string substring = "app";

            Console.WriteLine("Words containing '" + substring + "':");

            foreach (string word in words)
            {
                if (word.Contains(substring))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
