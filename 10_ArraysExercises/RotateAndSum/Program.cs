using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int rotateTimes = int.Parse(Console.ReadLine());

            // Create sum-array to store the sum of equivalent positions of the k different arrays
            int[] arraySum = new int[arrayInt.Length];

            for (int rotate = 1; rotate <= rotateTimes; rotate++)
            {
                // Preserve last element of array to move up front to the newly created array configuration
                int lastElement = arrayInt[arrayInt.Length - 1];
                for (int pointer = arrayInt.Length - 1; pointer >= 1; pointer--)
                {
                    arrayInt[pointer] = arrayInt[pointer - 1];
                    arraySum[pointer] += arrayInt[pointer];
                }
                // Move last element of previous array to first element of current array
                arrayInt[0] = lastElement;
                arraySum[0] += lastElement;
                // Note: We could have also used a separate loop to write the elements of the sum-array by
                //looping through the rotated array.
            }

            // Print the resulting members of the sum-array
            foreach (int membrer in arraySum)
            {
                Console.Write(membrer + " ");
            }
            Console.WriteLine();

        }
    }
}
