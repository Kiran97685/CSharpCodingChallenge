using System;

namespace CSharpCodingChallenge
{
    internal class Day34_DateTimeArrayAnalysis
    {
        public void AnalyzeDates()
        {
            DateTime[] dates =
            {
                new DateTime(2023, 5, 10),
                new DateTime(2021, 12, 1),
                new DateTime(2024, 1, 25),
                new DateTime(2022, 7, 18),
                new DateTime(2020, 3, 30)
            };

            DateTime oldest = dates[0];
            DateTime newest = dates[0];

            for (int i = 1; i < dates.Length; i++)
            {
                if (dates[i] < oldest)
                    oldest = dates[i];

                if (dates[i] > newest)
                    newest = dates[i];
            }

            TimeSpan difference = newest - oldest;

            Console.WriteLine("Oldest Date: " + oldest.ToShortDateString());
            Console.WriteLine("Newest Date: " + newest.ToShortDateString());
            Console.WriteLine("Total days between oldest and newest: " + difference.Days);
        }
    }
}
