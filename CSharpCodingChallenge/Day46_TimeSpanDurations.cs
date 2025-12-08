using System;

namespace CSharpCodingChallenge
{
    internal class Day46_TimeSpanDurations
    {
        public void AnalyzeDurations()
        {
            // Array of TimeSpan durations
            TimeSpan[] durations = new TimeSpan[]
            {
                new TimeSpan(1, 30, 0),  // 1 hour 30 min
                new TimeSpan(2, 45, 30), // 2 hours 45 min 30 sec
                new TimeSpan(0, 50, 10), // 50 min 10 sec
                new TimeSpan(3, 10, 0),  // 3 hours 10 min
                new TimeSpan(1, 5, 50)   // 1 hour 5 min 50 sec
            };

            TimeSpan total = TimeSpan.Zero;
            TimeSpan longest = durations[0];
            TimeSpan shortest = durations[0];

            // Calculate total, longest, shortest
            foreach (var d in durations)
            {
                total += d;

                if (d > longest)
                    longest = d;

                if (d < shortest)
                    shortest = d;
            }

            // Average = total / number of durations
            TimeSpan average = new TimeSpan(total.Ticks / durations.Length);

            Console.WriteLine("---- Duration Analysis ----");
            Console.WriteLine("Total Duration: " + total);
            Console.WriteLine("Average Duration: " + average);
            Console.WriteLine("Longest Duration: " + longest);
            Console.WriteLine("Shortest Duration: " + shortest);
        }
    }
}
