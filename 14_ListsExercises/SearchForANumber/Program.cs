using System;
using System.Linq;
using System.Collections.Generic;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] instructions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            integers.Take(instructions[0]);
            integers.RemoveRange(0, instructions[1]);

            if (integers.Contains(instructions[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
