using System;

namespace CSharpCodingChallenge
{
    internal class Day26_StringPalindromeWords
    {
        public void FindPalindromeWords()
        {
            string sentence = "level radar apple civic code madam racecar";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            Console.WriteLine("Palindrome words:");

            foreach (string word in words)
            {
                if (IsPalindrome(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        private bool IsPalindrome(string word)
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (word[start] != word[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }
}
