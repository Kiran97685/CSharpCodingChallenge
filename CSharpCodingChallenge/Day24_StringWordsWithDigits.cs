using System;

namespace CSharpCodingChallenge
{
    internal class Day24_StringWordsWithDigits
    {
        public void CountWordsWithDigits()
        {
            string sentence = "CSharp5 coding2025 learn2code version10 update";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            int count = 0;

            Console.WriteLine("Words containing digits:");

            foreach (string word in words)
            {
                if (ContainsDigit(word))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }

            Console.WriteLine("Total words with digits: " + count);
        }

        private bool ContainsDigit(string word)
        {
            foreach (char ch in word)
            {
                if (char.IsDigit(ch))
                    return true;
            }
            return false;
        }
    }
}
