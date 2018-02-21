using System;
using System.Linq;
using System.Collections.Generic;

namespace MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIntegers = int.Parse(Console.ReadLine());

            int[] integers = new int[numberIntegers];

            for (int integer = 0; integer < numberIntegers; integer++)
            {
                integers[integer] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum = {0}", integers.Sum());
            Console.WriteLine("Min = {0}", integers.Min());
            Console.WriteLine("Max = {0}", integers.Max());
            Console.WriteLine("Average = {0}", integers.Average());
        }
    }
}
