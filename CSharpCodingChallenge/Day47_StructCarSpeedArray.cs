using System;

namespace CSharpCodingChallenge
{
    internal class Day47_StructCarSpeed
    {
        // Define a struct (custom data type)
        struct Car
        {
            public string Brand;
            public int HorsePower;
            public int TopSpeed;

            public Car(string brand, int hp, int speed)
            {
                Brand = brand;
                HorsePower = hp;
                TopSpeed = speed;
            }
        }

        public void FindFastestCar()
        {
            // Array of struct (NOT int, NOT string, NOT tuple)
            Car[] cars = new Car[]
            {
                new Car("BMW", 450, 280),
                new Car("Audi", 420, 260),
                new Car("Mercedes", 500, 300),
                new Car("Ferrari", 700, 350),
                new Car("Lamborghini", 750, 355)
            };

            Car fastest = cars[0];

            foreach (Car c in cars)
            {
                if (c.TopSpeed > fastest.TopSpeed)
                {
                    fastest = c;
                }
            }

            Console.WriteLine("Fastest Car Details:");
            Console.WriteLine("Brand: " + fastest.Brand);
            Console.WriteLine("HorsePower: " + fastest.HorsePower);
            Console.WriteLine("Top Speed: " + fastest.TopSpeed + " km/h");
        }
    }
}
