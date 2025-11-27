using System;

namespace CSharpCodingChallenge
{
    internal class Day35_BooleanLongestTrueSequence
    {
        public void FindLongestTrueSequence()
        {
            bool[] flags = { true, true, false, true, true, true, false, true };

            int currentCount = 0;
            int longestCount = 0;

            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == true)
                {
                    currentCount++;

                    if (currentCount > longestCount)
                        longestCount = currentCount;
                }
                else
                {
                    currentCount = 0; // reset sequence
                }
            }

            Console.WriteLine("Longest consecutive TRUE sequence: " + longestCount);
        }
    }
}
