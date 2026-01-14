using System;

namespace CSharpCodingChallenge
{
    internal class Day83_ContainerWithMostWater
    {
        public void FindMaxWater()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            int left = 0;
            int right = height.Length - 1;
            int maxWater = 0;

            while (left < right)
            {
                int width = right - left;
                int minHeight = Math.Min(height[left], height[right]);
                int water = width * minHeight;

                if (water > maxWater)
                {
                    maxWater = water;
                }

                // Move the pointer with smaller height
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            Console.WriteLine("Maximum water that can be stored: " + maxWater);
        }
    }
}
