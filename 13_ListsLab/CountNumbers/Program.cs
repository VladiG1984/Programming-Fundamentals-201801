using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] counts = new int[integers.Max() + 1];

            foreach (int integer in integers)
            {
                counts[integer]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, counts[i]);
                }
            }
        }
    }
}
