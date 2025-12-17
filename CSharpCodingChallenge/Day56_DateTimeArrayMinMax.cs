using System;

namespace CSharpCodingChallenge
{
    internal class Day56_DateTimeArrayMinMax
    {
        public void FindEarliestAndLatestDate()
        {
            DateTime[] dates =
            {
                new DateTime(2023, 5, 10),
                new DateTime(2021, 12, 25),
                new DateTime(2024, 1, 1),
                new DateTime(2022, 8, 15),
                new DateTime(2020, 3, 20)
            };

            DateTime earliest = dates[0];
            DateTime latest = dates[0];

            for (int i = 1; i < dates.Length; i++)
            {
                if (dates[i] < earliest)
                {
                    earliest = dates[i];
                }

                if (dates[i] > latest)
                {
                    latest = dates[i];
                }
            }

            Console.WriteLine("Earliest Date: " + earliest.ToShortDateString());
            Console.WriteLine("Latest Date: " + latest.ToShortDateString());
        }
    }
}
