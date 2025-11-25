using System;

namespace CSharpCodingChallenge
{
    internal class Day33_BooleanStreakCounter
    {
        public void CountTrueStreaks()
        {
            bool[] flags = { true, true, false, true, false, true, true, true, false };

            int streakCount = 0;
            int currentStreak = 0;
            int longestStreak = 0;

            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == true)
                {
                    currentStreak++;

                    if (currentStreak == 1)
                    {
                        streakCount++; // New streak found
                    }

                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                    }
                }
                else
                {
                    currentStreak = 0; // Reset streak
                }
            }

            Console.WriteLine("Total TRUE streaks: " + streakCount);
            Console.WriteLine("Longest TRUE streak: " + longestStreak);
        }
    }
}
