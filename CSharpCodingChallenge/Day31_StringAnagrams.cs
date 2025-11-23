using System;

namespace CSharpCodingChallenge
{
    internal class Day31_StringAnagrams
    {
        public void FindAnagrams()
        {
            string[] words = { "listen", "silent", "care", "race", "hello", "world", "acre" };

            Console.WriteLine("Anagram pairs:\n");

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (IsAnagram(words[i], words[j]))
                    {
                        Console.WriteLine(words[i] + "  ↔  " + words[j]);
                    }
                }
            }
        }

        private bool IsAnagram(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            char[] arr1 = a.ToLower().ToCharArray();
            char[] arr2 = b.ToLower().ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }
    }
}
