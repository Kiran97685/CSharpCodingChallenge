using System;

namespace CSharpCodingChallenge
{
    internal class Day28_BooleanArrayCount
    {
        public void CountTrueFalse()
        {
            bool[] flags = { true, false, true, true, false, false, true };

            int trueCount = 0;
            int falseCount = 0;

            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == true)
                {
                    trueCount++;
                }
                else
                {
                    falseCount++;
                }
            }

            Console.WriteLine("Number of TRUE values: " + trueCount);
            Console.WriteLine("Number of FALSE values: " + falseCount);
        }
    }
}
