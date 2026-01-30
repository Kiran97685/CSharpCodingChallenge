using System;

namespace CSharpCodingChallenge
{
    internal class Day98_MinimumWindowSubstring
    {
        public void FindMinimumWindow()
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";

            int[] freq = new int[256];

            foreach (char c in t)
                freq[c]++;

            int left = 0, right = 0;
            int required = t.Length;
            int minLen = int.MaxValue;
            int startIndex = 0;

            while (right < s.Length)
            {
                if (freq[s[right]] > 0)
                    required--;

                freq[s[right]]--;
                right++;

                while (required == 0)
                {
                    if (right - left < minLen)
                    {
                        minLen = right - left;
                        startIndex = left;
                    }

                    freq[s[left]]++;

                    if (freq[s[left]] > 0)
                        required++;

                    left++;
                }
            }

            if (minLen == int.MaxValue)
                Console.WriteLine("No valid window found");
            else
                Console.WriteLine("Minimum window substring: " +
                    s.Substring(startIndex, minLen));
        }
    }
}
