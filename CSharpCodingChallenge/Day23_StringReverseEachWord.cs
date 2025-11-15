using System;

namespace CSharpCodingChallenge
{
    internal class Day27_StringReverseEachWord
    {
        public void ReverseEachWord()
        {
            string sentence = "CSharp makes coding interesting";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            Console.WriteLine("Reversed words (order same):");

            foreach (string word in words)
            {
                string reversed = ReverseWord(word);
                Console.Write(reversed + " ");
            }
        }

        private string ReverseWord(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
