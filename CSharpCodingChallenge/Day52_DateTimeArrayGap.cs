using System;

namespace CSharpCodingChallenge
{
    internal class Day52_DateTimeArrayGap
    {
        public void FindLongestGap()
        {
            DateTime[] dates =
            {
                new DateTime(2024, 1, 10),
                new DateTime(2024, 2, 5),
                new DateTime(2024, 3, 1),
                new DateTime(2024, 4, 20),
                new DateTime(2024, 6, 1)
            };

            double maxGap = 0;
            DateTime startDate = dates[0];
            DateTime endDate = dates[0];

            for (int i = 0; i < dates.Length - 1; i++)
            {
                double gap = (dates[i + 1] - dates[i]).TotalDays;

                if (gap > maxGap)
                {
                    maxGap = gap;
                    startDate = dates[i];
                    endDate = dates[i + 1];
                }
            }

            Console.WriteLine("Longest gap between dates:");
            Console.WriteLine("From: " + startDate.ToShortDateString());
            Console.WriteLine("To: " + endDate.ToShortDateString());
            Console.WriteLine("Gap (days): " + maxGap);
        }
    }
}
