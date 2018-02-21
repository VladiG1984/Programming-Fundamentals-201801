using System;
using System.Linq;
using System.Collections.Generic;

namespace LargesThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(String.Join(" ", realNumbers));


        }
    }
}
