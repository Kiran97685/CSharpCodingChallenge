using System;
namespace csharp.arrays
{
    internal class ReverseArray
    {
        public void Reverse()
        {
            // Step 1: Ask user how many elements they want in the array
            Console.Write("Enter the Size of elements: ");
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());

            // Step 2: Create an array of size 'n'
            int[] elementsArray = new int[sizeOfArray];

            //step 3: ask user tp input elements of the array
            Console.WriteLine("Enter the elements:");
            for (int index = 0; index < sizeOfArray; index++)
            {
                elementsArray[index] = Convert.ToInt32(Console.ReadLine());
            }
            //Step 4: Reverse the array in-place
            for (int index = 0; index < sizeOfArray / 2; index++)
            {
                //Swap element at position i with element at position(n-1-i)
                int temp = elementsArray[index];             //Store the current element in temp
                elementsArray[index] = elementsArray[sizeOfArray - 1 - index];       //Put the element from the end into current position
                elementsArray[sizeOfArray - 1 - index] = temp;         //Put the temp (original current element) at the end
            }

            //Step 5: Print the reversed array
            Console.WriteLine("\nReversed Array:");
            for (int i = 0; i < sizeOfArray; i++)
            {
                //Print each element followed by a space
                Console.Write(elementsArray[i] + " ");
            }
        }
    }
}