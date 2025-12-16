using System;

namespace CSharpCodingChallenge
{
    internal class Day55_FloatTrendDetection
    {
        public void DetectTrendChanges()
        {
            float[] readings = { 10.5f, 12.3f, 15.0f, 14.2f, 13.8f, 16.1f, 18.0f, 17.5f };

            Console.WriteLine("Trend change points:");

            for (int i = 1; i < readings.Length - 1; i++)
            {
                // Peak (increase → decrease)
                if (readings[i] > readings[i - 1] && readings[i] > readings[i + 1])
                {
                    Console.WriteLine($"Peak at index {i} : {readings[i]}");
                }
                // Valley (decrease → increase)
                else if (readings[i] < readings[i - 1] && readings[i] < readings[i + 1])
                {
                    Console.WriteLine($"Valley at index {i} : {readings[i]}");
                }
            }
        }
    }
}
