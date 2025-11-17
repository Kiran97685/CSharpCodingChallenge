using System;

namespace CSharpCodingChallenge
{
    internal class Day25_StartsWithLetter
    {
        public void CountNamesStartingWithLetter()
        {
            string[] names = { "Ravi", "Rohan", "Meera", "Rahul", "Sneha", "maya" };

            Console.Write("Enter a letter: ");
            char letter = char.ToLower(Console.ReadLine()[0]);

            int count = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (char.ToLower(names[i][0]) == letter)
                {
                    count++;
                }
            }

            Console.WriteLine("Names starting with '" + letter + "': " + count);
        }
    }
}
