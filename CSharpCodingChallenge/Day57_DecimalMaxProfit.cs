using System;

namespace CSharpCodingChallenge
{
    internal class Day57_DecimalMaxProfit
    {
        public void CalculateMaxProfit()
        {
            decimal[] prices = { 120.50m, 118.75m, 121.30m, 117.90m, 125.60m, 123.40m };

            decimal minPrice = prices[0];
            decimal maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    decimal profit = prices[i] - minPrice;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            Console.WriteLine("Maximum Profit: " + maxProfit);
        }
    }
}
