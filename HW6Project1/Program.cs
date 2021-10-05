/// Homework No. 6 Project No. 1
/// File Name : Program.cs
/// @author : Joshua Um
/// Date : Oct 4 2021
/// 
/// Problem Statement : Clone an array of integers.
/// 
/// Plan:
/// 1. Generate integer array with random integer numbers.
/// 2. Enter for loop to clone array
/// 3. Copy each value from original array to new array to clone.
/// 4. Print the values of clone array for comparsion.

using System;

namespace HW6Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            Random rand = new Random();

            // Fill array with random data.
            for (int i = 0, count = intArray.Length; i < count; i++)
            {
                intArray[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Original array : " + toStringArray(intArray));

            int[] cloneArray = new int[intArray.Length];

            //Read and copy data from original array.
            for (int i = 0, count = intArray.Length; i < count; i++)
            {
                cloneArray[i] = intArray[i];
            }

            Console.WriteLine("Clone array : " + toStringArray(cloneArray));



        }

        // Creates string of the array's contents.
        static String toStringArray(int[] arr)
        {
            String outputString = "";
            for (int i = 0, count = arr.Length; i < count; i++)
            {
                outputString += arr[i] + " ";
            }

            return outputString;

        }
    }
}
