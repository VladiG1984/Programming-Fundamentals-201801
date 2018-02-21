using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tokens = Console.ReadLine().Split('|').ToList();

            List<int> results = new List<int>();

            //Console.WriteLine(String.Join(", ", tokens));

            tokens.Reverse();

            //Console.WriteLine(String.Join(", ", tokens));

            foreach (string token in tokens)
            {
                List<int> values = token.Split(' ')
                    .Where(s => !string.IsNullOrWhiteSpace(s))
                    .Select(int.Parse)
                    .ToList();

                //Console.WriteLine(String.Join(", ", values));

                for (int element = 0; element < values.Count; element++)
                {
                    results.Add(values[element]);
                }
            }
            Console.WriteLine(String.Join(" ", results));
        }
    }
}
