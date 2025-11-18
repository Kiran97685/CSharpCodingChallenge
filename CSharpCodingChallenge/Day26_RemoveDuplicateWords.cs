using System;

namespace CSharpCodingChallenge
{
    internal class Day26_RemoveDuplicateWords
    {
        public void RemoveDuplicates()
        {
            string sentence = "this is a test this is coding test";

            string[] words = sentence.Split(' ');
            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                bool exists = false;

                // check if word already added
                for (int j = 0; j < i; j++)
                {
                    if (words[i] == words[j])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    result += words[i] + " ";
                }
            }

            Console.WriteLine("Original: " + sentence);
            Console.WriteLine("After removing duplicates: " + result.Trim());
        }
    }
}
