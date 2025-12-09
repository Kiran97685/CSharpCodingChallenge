using System;

namespace CSharpCodingChallenge
{
    internal class Day48_StructInventoryArray
    {
        // Define a struct for Product
        struct Product
        {
            public string Name;
            public double Price;
            public int Quantity;

            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }

        public void CalculateInventoryValue()
        {
            // Array of struct
            Product[] products = new Product[]
            {
                new Product("Laptop", 55000.50, 5),
                new Product("Keyboard", 1500.75, 20),
                new Product("Headphones", 2500.00, 15),
                new Product("Monitor", 12000.99, 8)
            };

            double totalValue = 0;

            Console.WriteLine("Product Inventory Details:");
            Console.WriteLine("---------------------------");

            foreach (var p in products)
            {
                double value = p.Price * p.Quantity;
                totalValue += value;

                Console.WriteLine($"{p.Name} - Price: {p.Price}, Qty: {p.Quantity}, Value: {value}");
            }

            Console.WriteLine("\nTotal Inventory Value: " + totalValue);
        }
    }
}
