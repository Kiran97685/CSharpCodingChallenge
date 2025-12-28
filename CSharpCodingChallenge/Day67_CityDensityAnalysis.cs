using System;

namespace CSharpCodingChallenge
{
    internal class Day67_CityDensityAnalysis
    {
        // Custom class used inside the same file
        class City
        {
            public string Name;
            public int Population;
            public double Area;   // in square km

            public City(string name, int population, double area)
            {
                Name = name;
                Population = population;
                Area = area;
            }
        }

        public void FindHighestDensityCity()
        {
            City[] cities =
            {
                new City("Bangalore", 12000000, 709.5),
                new City("Delhi", 32000000, 1484),
                new City("Mumbai", 21000000, 603.4),
                new City("Chennai", 11500000, 426)
            };

            City highestDensityCity = cities[0];
            double highestDensity = cities[0].Population / cities[0].Area;

            for (int i = 1; i < cities.Length; i++)
            {
                double density = cities[i].Population / cities[i].Area;

                if (density > highestDensity)
                {
                    highestDensity = density;
                    highestDensityCity = cities[i];
                }
            }

            Console.WriteLine("City with Highest Population Density:");
            Console.WriteLine("Name: " + highestDensityCity.Name);
            Console.WriteLine("Density: " + highestDensity + " people/km²");
        }
    }
}
