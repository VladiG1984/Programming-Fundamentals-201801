using System;
using System.Linq;
using System.Collections.Generic;

namespace AppendLists_Version2
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
                List<string> values = token.Split(' ').ToList();

                // Note: the following loop could be substituted with:
                // values.RemoveAll(c => c == "");

                for (int element = 0; element < values.Count; element++)
                {
                    values.Remove("");
                }

                for (int element = 0; element < values.Count; element++)
                {
                    results.Add(int.Parse(values[element]));
                }
            }
            Console.WriteLine(String.Join(" ", results));
        }
    }
}
