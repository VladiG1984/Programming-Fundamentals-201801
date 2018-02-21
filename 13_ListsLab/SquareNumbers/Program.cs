using System;
using System.Linq;
using System.Collections.Generic;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squares = new List<int>();

            foreach (int integer in integers)
            {
                if (Math.Sqrt(integer) == (int)Math.Sqrt(integer))
                {
                    squares.Add(integer);
                }
            }

            //squares.Sort();
            //squares.Reverse();

            // Instead of above sort and then reverse to obtain reversed sort

            squares.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(String.Join(" ", squares));
        }
    }
}
