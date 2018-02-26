using System;
using System.Linq;

namespace SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment: Works using a string array, but with more knowledge maybe there is a more appropriate way
            // to do it.
            string[] time = Console.ReadLine().Split().OrderBy(t => t).ToArray();

            Console.WriteLine(String.Join(", ", time));

        }
    }
}
