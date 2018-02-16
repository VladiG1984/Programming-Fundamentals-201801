using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayIntOriginal = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int arrayOrgLength = arrayIntOriginal.Length;

            // Create two new arrays of equal length (2 * k - i.e., 1/2 of original array's length).
            // These are to be subsequently summed.
            // First array will hold the two ends of the original array, each of length k.
            // Second array will hold the middle 2 * k elements of the orginal array.

            int[] arrayIntEnds = new int[arrayOrgLength / 2];
            int[] arrayIntMiddle = new int[arrayOrgLength / 2];

            // Assign values to elements of the new array containing the ends of original array.
            for (int pointer = 0; pointer < arrayOrgLength / 4; pointer++)
            {
                arrayIntEnds[arrayOrgLength / 4 - 1 - pointer] = arrayIntOriginal[pointer];
                arrayIntEnds[arrayOrgLength / 4 + pointer] = arrayIntOriginal[arrayOrgLength - 1 - pointer];
            }

            // Assign values to elements of the new array containing the middile of original array.
            for (int pointer = 0, oneQuarterOrigArr = arrayOrgLength / 4; pointer < arrayOrgLength / 2; pointer++)
            {
                arrayIntMiddle[pointer] = arrayIntOriginal[oneQuarterOrigArr + pointer];
            }

            // Calculate sum of elements of equivalent positions in the two newly created arrays.
            // Print sum on the console.
            for (int member = 0; member < arrayOrgLength / 2; member++)
            {
                int sum = arrayIntEnds[member] + arrayIntMiddle[member];
                Console.Write("{0} ", sum);
            }
            Console.WriteLine();

        }
    }
}
