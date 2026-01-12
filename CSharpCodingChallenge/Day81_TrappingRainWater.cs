using System;

namespace CSharpCodingChallenge
{
    internal class Day81TrappingRainWater
    {
        public void CalculateTrappedWater()
        {
            int[] height = { 4, 2, 0, 3, 2, 5 };
            int n = height.Length;

            int[] leftMax = new int[n];
            int[] rightMax = new int[n];

            // Fill leftMax array
            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            // Fill rightMax array
            rightMax[n - 1] = height[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            int waterTrapped = 0;

            for (int i = 0; i < n; i++)
            {
                waterTrapped += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }

            Console.WriteLine("Total trapped rain water: " + waterTrapped);
        }
    }
}
