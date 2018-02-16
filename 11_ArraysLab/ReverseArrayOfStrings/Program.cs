using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayString = Console.ReadLine().Trim().Split(' ').ToArray();
            int arrayLength = arrayString.Length;
            string[] arrayStringReversed = new string[arrayLength];

            // First approach (longer);
            //for (int element = 0; element < arrayLength; element++)
            //{
            //    arrayStringReversed[arrayLength - 1 - element] = arrayString[element];
            //}

            //foreach (string element in arrayStringReversed)
            //{
            //    Console.Write($"{element} ");
            //}
            //Console.WriteLine();

            foreach (string element in arrayString.Reverse())
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
