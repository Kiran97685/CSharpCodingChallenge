using System;

namespace CSharpCodingChallenge
{
    internal class Day96_StringCompression
    {
        public void CompressString()
        {
            string input = "aaabbccccdaa";

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty string");
                return;
            }

            string result = "";
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    result += input[i - 1] + count.ToString();
                    count = 1;
                }
            }

            // Add last character
            result += input[input.Length - 1] + count.ToString();

            Console.WriteLine("Compressed string: " + result);
        }
    }
}
