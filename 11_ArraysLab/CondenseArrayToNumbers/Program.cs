using System;
using System.Linq;

namespace CondenseArrayToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int arrayLength = arrayInt.Length;

            // Create temporary arrays of incremental length, which initially equals length of initial array - 1
            // and with each step of the loop decreases by 1
            for (int arrayIncrementlength = arrayLength - 1; arrayIncrementlength >= 1; arrayIncrementlength--)
            {
                int[] arrayCondensed = new int[arrayIncrementlength];

                // Fill in the values of each incremental array with the sum of the values at the current position
                // from the previous loop and the one before it
                for (int element = 0; element <= arrayIncrementlength - 1; element++)
                {
                    arrayCondensed[element] = arrayInt[element] + arrayInt[element + 1];
                }
                // Overwrite initial array with the clone of the incremental array
                arrayInt = arrayCondensed.Clone() as int[];

            }
            // In the end we must reduce the intial array to an array of length one, which we print on the console
            foreach (int element in arrayInt)
            {
                Console.WriteLine(element);
            }
        }
    }
}
