using System;

namespace CSharpCodingChallenge
{
    internal class Day53_FloatArraySensorSpike
    {
        public void DetectSpikes()
        {
            float[] readings = { 20.5f, 21.0f, 21.3f, 30.0f, 30.5f, 40.0f, 41.2f };

            Console.WriteLine("Sensor spikes detected:");

            for (int i = 1; i < readings.Length; i++)
            {
                float previous = readings[i - 1];
                float current = readings[i];

                float increasePercentage = ((current - previous) / previous) * 100;

                if (increasePercentage >= 30)
                {
                    Console.WriteLine(
                        "Spike at index " + i +
                        " | Previous: " + previous +
                        " | Current: " + current +
                        " | Increase: " + increasePercentage.ToString("0.00") + "%"
                    );
                }
            }
        }
    }
}
