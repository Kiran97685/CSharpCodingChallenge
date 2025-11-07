using System;

namespace CSharpCodingChallenge
{
    internal class Day15_StringWordCount
    {
        public void CountWords()
        {
            string sentence = "welcome to csharp welcome to coding";

            // Split into words (array)
            string[] words = sentence.Split(' ');

            Console.WriteLine("Total words: " + words.Length);

            foreach (string w in words)
            {
                Console.WriteLine(w);
            }
        }
    }
}
