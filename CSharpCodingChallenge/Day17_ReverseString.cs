using System;

namespace CSharpCodingChallenge
{
    internal class Day17_StringReverseWords
    {
        public void ReverseWords()
        {
            string sentence = "welcome to csharp programming";

            // Convert string → word array
            string[] words = sentence.Split(' ');

            Console.WriteLine("Words in reverse order:");
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
