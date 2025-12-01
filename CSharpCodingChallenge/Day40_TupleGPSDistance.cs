using System;

namespace CSharpCodingChallenge
{
    internal class Day40_TupleGPSDistance
    {
        public void FarthestDistance()
        {
            // Tuple array: (Latitude, Longitude)
            (double Latitude, double Longitude)[] locations = new (double, double)[]
            {
                (12.9716, 77.5946), // Bangalore
                (28.7041, 77.1025), // Delhi
                (19.0760, 72.8777), // Mumbai
                (13.0827, 80.2707)  // Chennai
            };

            double maxDistance = 0;
            (double Latitude, double Longitude) point1 = locations[0];
            (double Latitude, double Longitude) point2 = locations[0];

            for (int i = 0; i < locations.Length; i++)
            {
                for (int j = i + 1; j < locations.Length; j++)
                {
                    double distance = CalculateDistance(locations[i], locations[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        point1 = locations[i];
                        point2 = locations[j];
                    }
                }
            }

            Console.WriteLine("Farthest distance is between:");
            Console.WriteLine($"Point1: ({point1.Latitude}, {point1.Longitude})");
            Console.WriteLine($"Point2: ({point2.Latitude}, {point2.Longitude})");
            Console.WriteLine("Distance (km): " + maxDistance);
        }

        // Haversine formula to calculate distance between two lat-long points
        private double CalculateDistance((double Latitude, double Longitude) p1, (double Latitude, double Longitude) p2)
        {
            double R = 6371; // Radius of Earth in km
            double lat1Rad = p1.Latitude * Math.PI / 180;
            double lat2Rad = p2.Latitude * Math.PI / 180;
            double deltaLat = (p2.Latitude - p1.Latitude) * Math.PI / 180;
            double deltaLon = (p2.Longitude - p1.Longitude) * Math.PI / 180;

            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c;
        }
    }
}
