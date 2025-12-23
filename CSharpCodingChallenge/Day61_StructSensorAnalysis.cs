using System;

namespace CSharpCodingChallenge
{
    internal class Day61_StructSensorAnalysis
    {
        struct Sensor
        {
            public int SensorId;
            public double Temperature;
            public double Pressure;
        }

        public void AnalyzeSensors()
        {
            Sensor[] sensors = new Sensor[]
            {
                new Sensor { SensorId = 101, Temperature = 36.5, Pressure = 1.2 },
                new Sensor { SensorId = 102, Temperature = 40.1, Pressure = 1.0 },
                new Sensor { SensorId = 103, Temperature = 38.9, Pressure = 0.9 },
                new Sensor { SensorId = 104, Temperature = 35.7, Pressure = 1.4 }
            };

            Sensor highestTemp = sensors[0];
            Sensor lowestPressure = sensors[0];

            foreach (Sensor s in sensors)
            {
                if (s.Temperature > highestTemp.Temperature)
                    highestTemp = s;

                if (s.Pressure < lowestPressure.Pressure)
                    lowestPressure = s;
            }

            Console.WriteLine("Sensor with Highest Temperature:");
            Console.WriteLine("ID: " + highestTemp.SensorId +
                              ", Temp: " + highestTemp.Temperature +
                              ", Pressure: " + highestTemp.Pressure);

            Console.WriteLine();

            Console.WriteLine("Sensor with Lowest Pressure:");
            Console.WriteLine("ID: " + lowestPressure.SensorId +
                              ", Temp: " + lowestPressure.Temperature +
                              ", Pressure: " + lowestPressure.Pressure);
        }
    }
}
