using System;

namespace CSharpCodingChallenge
{
    internal class Day93_LongestUniqueSubstring
    {
        public void FindLongestUniqueSubstring()
        {
            string input = "abcabcbb";

            int start = 0;
            int maxLength = 0;
            int[] lastIndex = new int[256];

            for (int i = 0; i < 256; i++)
                lastIndex[i] = -1;

            for (int end = 0; end < input.Length; end++)
            {
                char currentChar = input[end];

                if (lastIndex[currentChar] >= start)
                {
                    start = lastIndex[currentChar] + 1;
                }

                lastIndex[currentChar] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            Console.WriteLine("Longest unique substring length: " + maxLength);
        }
    }
}
