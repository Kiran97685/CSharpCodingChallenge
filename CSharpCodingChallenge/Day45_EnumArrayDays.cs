using System;

namespace CSharpCodingChallenge
{
    // Enum representing days of the week
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    internal class Day45_EnumArrayDays
    {
        public void CountWeekdaysWeekends()
        {
            // Enum array
            Days[] schedule = new Days[]
            {
                Days.Monday, Days.Wednesday, Days.Saturday,
                Days.Sunday, Days.Friday, Days.Tuesday,
                Days.Saturday, Days.Thursday
            };

            int weekdayCount = 0;
            int weekendCount = 0;

            foreach (Days day in schedule)
            {
                if (day == Days.Saturday || day == Days.Sunday)
                    weekendCount++;
                else
                    weekdayCount++;
            }

            Console.WriteLine("Total Days in Schedule: " + schedule.Length);
            Console.WriteLine("Weekdays Count: " + weekdayCount);
            Console.WriteLine("Weekend Count: " + weekendCount);
        }
    }
}
