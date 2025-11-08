using System;
using System.Collections.Generic;

namespace CSharpCodingChallenge
{
    internal class Day16_StringCharFrequency
    {
        public void CountCharFrequency()
        {
            string text = "programming";

            char[] chars = text.ToCharArray();
            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }

            Console.WriteLine("Character Frequency:");
            foreach (var item in freq)
            {
                Console.WriteLine(item.Key + " → " + item.Value);
            }
        }
    }
}
