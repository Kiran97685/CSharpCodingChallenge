using System;

namespace CSharpCodingChallenge
{
    internal class Day95_IsomorphicStrings
    {
        public void CheckIsomorphic()
        {
            string s = "egg";
            string t = "add";

            if (s.Length != t.Length)
            {
                Console.WriteLine("Strings are NOT isomorphic");
                return;
            }

            int[] mapST = new int[256];
            int[] mapTS = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i];
                char c2 = t[i];

                if (mapST[c1] == 0 && mapTS[c2] == 0)
                {
                    mapST[c1] = c2;
                    mapTS[c2] = c1;
                }
                else if (mapST[c1] != c2 || mapTS[c2] != c1)
                {
                    Console.WriteLine("Strings are NOT isomorphic");
                    return;
                }
            }

            Console.WriteLine("Strings are isomorphic");
        }
    }
}
