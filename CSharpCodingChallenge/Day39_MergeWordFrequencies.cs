using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCodingChallenge
{
    internal class Day39_ArrayOfDictionaries
    {
        public void MergeWordFrequencies()
        {
            // Array of dictionaries (complex type)
            Dictionary<string, int>[] wordData = new Dictionary<string, int>[]
            {
                new Dictionary<string, int>()
                {
                    { "apple", 2 },
                    { "banana", 1 },
                    { "mango", 3 }
                },

                new Dictionary<string, int>()
                {
                    { "banana", 4 },
                    { "apple", 1 },
                    { "orange", 2 }
                },

                new Dictionary<string, int>()
                {
                    { "grape", 5 },
                    { "mango", 2 },
                    { "apple", 3 }
                }
            };

            // Final merged result
            Dictionary<string, int> totalFrequency = new Dictionary<string, int>();

            // Merge each dictionary
            foreach (var dict in wordData)
            {
                foreach (var item in dict)
                {
                    if (totalFrequency.ContainsKey(item.Key))
                        totalFrequency[item.Key] += item.Value;
                    else
                        totalFrequency[item.Key] = item.Value;
                }
            }

            // Sort final result by highest frequency
            var sortedResult = totalFrequency.OrderByDescending(x => x.Value);

            Console.WriteLine("Total merged word frequencies:");
            foreach (var item in sortedResult)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
