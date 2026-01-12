using System;

namespace CSharpCodingChallenge
{
    internal class Day80_EquilibriumIndex
    {
        public void FindEquilibrium()
        {
            int[] numbers = { -7, 1, 5, 2, -4, 3, 0 };

            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum += numbers[i];
            }

            int leftSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                totalSum -= numbers[i]; // now this is right sum

                if (leftSum == totalSum)
                {
                    Console.WriteLine("Equilibrium index found at: " + i);
                    return;
                }

                leftSum += numbers[i];
            }

            Console.WriteLine("No equilibrium index found.");
        }
    }
}
