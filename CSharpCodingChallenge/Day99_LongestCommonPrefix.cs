using System;

namespace CSharpCodingChallenge
{
    internal class Day99_LongestCommonPrefix
    {
        public void FindLongestCommonPrefix()
        {
            string[] words = { "flower", "flow", "flight" };

            if (words.Length == 0)
            {
                Console.WriteLine("No strings provided");
                return;
            }

            string prefix = words[0];

            for (int i = 1; i < words.Length; i++)
            {
                while (words[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    if (prefix.Length == 0)
                    {
                        Console.WriteLine("No common prefix");
                        return;
                    }
                }
            }

            Console.WriteLine("Longest common prefix: " + prefix);
        }
    }
}
