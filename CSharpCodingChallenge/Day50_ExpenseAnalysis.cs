using System;

namespace CSharpCodingChallenge
{
    internal class Day50_ExpenseAnalysis
    {
        public void AnalyzeExpenses()
        {
            // Decimal array (money values)
            decimal[] expenses = { 1250.50m, 830.75m, 450.00m, 2999.99m, 1800.25m, 999.99m };

            decimal total = 0;
            decimal highest = expenses[0];
            decimal lowest = expenses[0];

            for (int i = 0; i < expenses.Length; i++)
            {
                total += expenses[i];

                if (expenses[i] > highest)
                    highest = expenses[i];

                if (expenses[i] < lowest)
                    lowest = expenses[i];
            }

            decimal average = total / expenses.Length;

            Console.WriteLine("Total Expenses: " + total);
            Console.WriteLine("Average Expense: " + average);
            Console.WriteLine("Highest Expense: " + highest);
            Console.WriteLine("Lowest Expense: " + lowest);
        }
    }
}
