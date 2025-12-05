using System;

namespace CSharpCodingChallenge
{
    internal class Day43_DateTimeArrayLongestGap
    {
        public void FindLongestGap()
        {
            // Array of dates
            DateTime[] dates = new DateTime[]
            {
                new DateTime(2023, 10, 15),
                new DateTime(2023, 10, 20),
                new DateTime(2023, 11, 05),
                new DateTime(2023, 11, 25),
                new DateTime(2024, 01, 10)
            };

            // Sort dates (important)
            Array.Sort(dates);

            int maxGap = 0;
            DateTime startDate = dates[0];
            DateTime endDate = dates[0];

            for (int i = 0; i < dates.Length - 1; i++)
            {
                int gap = (dates[i + 1] - dates[i]).Days;

                if (gap > maxGap)
                {
                    maxGap = gap;
                    startDate = dates[i];
                    endDate = dates[i + 1];
                }
            }

            Console.WriteLine("Longest Gap Between Two Dates:");
            Console.WriteLine("Start Date: " + startDate.ToShortDateString());
            Console.WriteLine("End Date: " + endDate.ToShortDateString());
            Console.WriteLine("Gap in Days: " + maxGap);
        }
    }
}
