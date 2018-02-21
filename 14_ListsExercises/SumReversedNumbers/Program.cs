using System;
using System.Linq;
using System.Collections.Generic;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            numbers.Reverse();

            // reverse each element of the list
            for (int i = 0; i < numbers.Count; i++)
            {
                int remainder = 0;
                int number = numbers[i];
                int reversedNumber = 0;

                // reverse element
                while (number != 0)
                {
                    remainder = number % 10;
                    number = number / 10;
                    reversedNumber = reversedNumber * 10 + remainder;
                }

                // write reversed element in place of initial, non-reversed element
                numbers[i] = reversedNumber;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
