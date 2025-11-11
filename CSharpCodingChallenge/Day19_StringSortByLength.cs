using System;

namespace CSharpCodingChallenge
{
    internal class Day21_StringSortByLength
    {
        public void SortWordsByLength()
        {
            string sentence = "CSharp is a powerful and flexible programming language";

            // Convert string → array of words
            string[] words = sentence.Split(' ');

            // Sort by length (ascending)
            Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));

            Console.WriteLine("Words sorted by length:");
            foreach (string w in words)
            {
                Console.WriteLine(w + " (Length: " + w.Length + ")");
            }
        }
    }
}
