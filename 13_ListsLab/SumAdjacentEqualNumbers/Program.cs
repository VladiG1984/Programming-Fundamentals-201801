using System;
using System.Linq;
using System.Collections.Generic;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int element = 0; element < numbers.Count - 1; element++)
            {
                if (numbers[element] == numbers[element + 1])
                {
                    numbers[element] += numbers[element];
                    numbers.RemoveAt(element + 1);
                    element = -1;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
