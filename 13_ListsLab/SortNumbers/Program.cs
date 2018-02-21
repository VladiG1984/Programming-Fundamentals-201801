using System;
using System.Linq;
using System.Collections.Generic;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> decimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            decimals.Sort();

            Console.WriteLine(String.Join(" <= ", decimals));
        }
    }
}
