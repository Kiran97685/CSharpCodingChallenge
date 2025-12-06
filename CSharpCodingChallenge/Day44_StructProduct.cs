using System;

namespace CSharpCodingChallenge
{
    internal class Day44_StructProduct
    {
        struct Product
        {
            public string Name;
            public int Quantity;
            public decimal Price;

            public Product(string name, int quantity, decimal price)
            {
                Name = name;
                Quantity = quantity;
                Price = price;
            }
        }

        public void HighestPricePerUnit()
        {
            Product[] products = new Product[]
            {
                new Product("Laptop", 5, 3500m),
                new Product("Mouse", 50, 900m),
                new Product("Keyboard", 30, 2400m),
                new Product("Monitor", 10, 5000m),
                new Product("USB Cable", 100, 2000m)
            };

            decimal maxRatio = 0;
            Product topProduct = products[0];

            foreach (var product in products)
            {
                decimal ratio = product.Price / product.Quantity;

                if (ratio > maxRatio)
                {
                    maxRatio = ratio;
                    topProduct = product;
                }
            }

            Console.WriteLine("Product with Highest Price Per Unit:");
            Console.WriteLine("Name: " + topProduct.Name);
            Console.WriteLine("Quantity: " + topProduct.Quantity);
            Console.WriteLine("Price: " + topProduct.Price);
            Console.WriteLine("Price per Unit: " + maxRatio);
        }
    }
}
