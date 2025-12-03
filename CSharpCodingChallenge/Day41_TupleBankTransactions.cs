using System;

namespace CSharpCodingChallenge
{
    internal class Day41_TupleBankTransactions
    {
        public void AnalyzeBankTransactions()
        {
            // Tuple format: (Date, Description, Amount, Type)
            // Type = "Credit" or "Debit"
            (DateTime Date, string Description, decimal Amount, string Type)[] transactions =
            {
                (new DateTime(2025, 1, 1), "Salary", 4500.00m, "Credit"),
                (new DateTime(2025, 1, 3), "Rent", 1200.00m, "Debit"),
                (new DateTime(2025, 1, 5), "Groceries", 230.75m, "Debit"),
                (new DateTime(2025, 1, 10), "Freelance Project", 900.00m, "Credit"),
                (new DateTime(2025, 1, 15), "Electricity Bill", 160.50m, "Debit"),
                (new DateTime(2025, 1, 20), "Bonus", 700.00m, "Credit")
            };

            decimal totalCredit = 0;
            decimal totalDebit = 0;

            foreach (var tx in transactions)
            {
                if (tx.Type == "Credit")
                    totalCredit += tx.Amount;
                else if (tx.Type == "Debit")
                    totalDebit += tx.Amount;
            }

            decimal finalBalance = totalCredit - totalDebit;

            Console.WriteLine("------ Bank Transaction Summary ------\n");
            Console.WriteLine("Total Credit: $" + totalCredit);
            Console.WriteLine("Total Debit : $" + totalDebit);
            Console.WriteLine("Final Balance: $" + finalBalance);
            Console.WriteLine("\nDetailed Transactions:");

            foreach (var tx in transactions)
            {
                Console.WriteLine($"{tx.Date.ToShortDateString()} | {tx.Description} | {tx.Type} | ${tx.Amount}");
            }
        }
    }
}
