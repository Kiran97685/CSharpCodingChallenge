using System;

namespace CSharpCodingChallenge
{
    internal class Day54_FloatArrayNormalization
    {
        public void NormalizeReadings()
        {
            float[] readings = { 45.5f, 60.2f, 30.8f, 90.0f, 75.4f };

            float min = readings[0];
            float max = readings[0];

            // Find min and max
            for (int i = 1; i < readings.Length; i++)
            {
                if (readings[i] < min)
                    min = readings[i];

                if (readings[i] > max)
                    max = readings[i];
            }

            Console.WriteLine("Normalized Sensor Readings (0 to 1):");

            // Normalize values
            for (int i = 0; i < readings.Length; i++)
            {
                float normalized = (readings[i] - min) / (max - min);
                Console.WriteLine($"Original: {readings[i]} → Normalized: {normalized:F2}");
            }
        }
    }
}
