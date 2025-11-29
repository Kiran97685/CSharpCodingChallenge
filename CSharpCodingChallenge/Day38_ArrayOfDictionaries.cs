using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCodingChallenge
{
    internal class Day38_ArrayOfDictionaries
    {
        public void FindHighestValueDictionary()
        {
            // Array of dictionaries (complex datatype)
            Dictionary<string, double>[] productBatches = new Dictionary<string, double>[]
            {
                new Dictionary<string, double>
                {
                    {"Keyboard", 45.5 },
                    {"Mouse", 15.0 },
                    {"USB Cable", 5.25 }
                },
                new Dictionary<string, double>
                {
                    {"Monitor", 155.0 },
                    {"Stand", 20.5 }
                },
                new Dictionary<string, double>
                {
                    {"Laptop", 850.4 },
                    {"Bag", 45.2 },
                    {"Charger", 30.0 }
                }
            };

            int highestIndex = 0;
            double highestSum = 0;

            for (int i = 0; i < productBatches.Length; i++)
            {
                double batchTotal = productBatches[i].Values.Sum();

                Console.WriteLine($"Batch {i + 1} Total: {batchTotal}");

                if (batchTotal > highestSum)
                {
                    highestSum = batchTotal;
                    highestIndex = i;
                }
            }

            Console.WriteLine("\nBatch with highest total value:");
            Console.WriteLine($"Batch {highestIndex + 1} → Total Value = {highestSum}");

            Console.WriteLine("Items:");
            foreach (var item in productBatches[highestIndex])
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
