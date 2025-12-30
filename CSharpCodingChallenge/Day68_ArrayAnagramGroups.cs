using System;

namespace CSharpCodingChallenge
{
    internal class Day68_ArrayAnagramGroups
    {
        public void GroupAnagrams()
        {
            string[] words = { "listen", "silent", "enlist", "rat", "tar", "art", "dog", "god" };

            bool[] visited = new bool[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (visited[i])
                    continue;

                Console.Write(words[i]);
                visited[i] = true;

                char[] first = words[i].ToCharArray();
                Array.Sort(first);

                for (int j = i + 1; j < words.Length; j++)
                {
                    if (!visited[j])
                    {
                        char[] second = words[j].ToCharArray();
                        Array.Sort(second);

                        string sorted1 = new string(first);
                        string sorted2 = new string(second);

                        if (sorted1 == sorted2)
                        {
                            Console.Write(" , " + words[j]);
                            visited[j] = true;
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
