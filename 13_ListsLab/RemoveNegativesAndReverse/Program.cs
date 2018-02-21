using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> listIntNonNegative = new List<int>();

            for(int position = listInt.Count - 1; position >= 0; position--)
            {
                if (listInt[position] >= 0)
                {
                    listIntNonNegative.Add(listInt[position]);
                }
            }

            Console.WriteLine(listIntNonNegative.Count > 0 ? String.Join(" ", listIntNonNegative) : "empty");
            
        }
    }
}
