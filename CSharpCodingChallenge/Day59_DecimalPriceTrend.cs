using System;

namespace CSharpCodingChallenge
{
    internal class Day59_DecimalPriceTrend
    {
        public void AnalyzePriceTrend()
        {
            decimal[] prices = { 100.50m, 102.75m, 101.25m, 101.25m, 105.00m };

            Console.WriteLine("Price Trend Analysis:");

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    Console.WriteLine($"Day {i}: Price Increased");
                }
                else if (prices[i] < prices[i - 1])
                {
                    Console.WriteLine($"Day {i}: Price Decreased");
                }
                else
                {
                    Console.WriteLine($"Day {i}: Price Unchanged");
                }
            }
        }
    }
}
