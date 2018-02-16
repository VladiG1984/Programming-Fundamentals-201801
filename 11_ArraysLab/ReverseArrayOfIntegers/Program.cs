using System;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayInt = new int[arrayLength];

            // Read array from console
            for (int arrayPointer = 0; arrayPointer < arrayLength; arrayPointer++)
            {
                arrayInt[arrayPointer] = int.Parse(Console.ReadLine());
            }

            // Write array to console
            for (int arrayPointer = arrayLength - 1; arrayPointer >= 0; arrayPointer--)
            {
                Console.Write($"{arrayInt[arrayPointer]} ", arrayInt[arrayPointer]);
            }
            Console.WriteLine();

        }
    }
}
