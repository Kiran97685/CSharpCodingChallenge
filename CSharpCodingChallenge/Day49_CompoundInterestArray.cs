using System;

namespace CSharpCodingChallenge
{
    internal class Day49_CompoundInterestArray
    {
        public void CalculateCompoundInterest()
        {
            // yearly interest rates (decimal is used for financial calculations)
            decimal[] interestRates = { 0.05m, 0.06m, 0.045m, 0.055m, 0.05m };

            decimal principal = 10000m;   // initial amount
            decimal amount = principal;

            Console.WriteLine("Year-wise Compound Interest Calculation:");
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < interestRates.Length; i++)
            {
                amount = amount + (amount * interestRates[i]);

                Console.WriteLine($"Year {i + 1}: Rate = {interestRates[i] * 100}%  →  Amount = {amount}");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Final Amount after " + interestRates.Length + " years: " + amount);
        }
    }
}
