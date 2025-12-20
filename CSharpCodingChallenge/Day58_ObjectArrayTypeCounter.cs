using System;

namespace CSharpCodingChallenge
{
    internal class Day58_ObjectArrayTypeCounter
    {
        public void CountObjectTypes()
        {
            object[] items = { 10, "Hello", 25.5, 100m, "World", 42, 99.9, 50m };

            int intCount = 0;
            int stringCount = 0;
            int doubleCount = 0;
            int decimalCount = 0;

            foreach (object item in items)
            {
                if (item is int)
                    intCount++;
                else if (item is string)
                    stringCount++;
                else if (item is double)
                    doubleCount++;
                else if (item is decimal)
                    decimalCount++;
            }

            Console.WriteLine("Object Array Type Count:");
            Console.WriteLine("Integers: " + intCount);
            Console.WriteLine("Strings: " + stringCount);
            Console.WriteLine("Doubles: " + doubleCount);
            Console.WriteLine("Decimals: " + decimalCount);
        }
    }
}
