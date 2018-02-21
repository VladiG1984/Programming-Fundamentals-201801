using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
         {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal[] bomb = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            decimal bombNumber = bomb[0];
            int bombPower = (int)bomb[1];

            // search for bomb within the list by checking each and every element
            for (int position = 0; position < numbers.Count; position++)
            {
                if (numbers[position] == bombNumber)
                {
                    // Remove according to power of bomb (in range)
                    int removeLeft = Math.Min(position, bombPower);
                    int remainingList = numbers.Count - position - 1;
                    int removeRight = Math.Min(remainingList, bombPower);
                    int removeTotal = removeLeft + removeRight + 1;
                    int index = position - removeLeft;

                    numbers.RemoveRange(index, removeTotal);    

                    // after removing a position with a bomb move one step back because we can miss a bomb due to
                    // deletion from the list and its subsequent update of index (position)
                    position--;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
