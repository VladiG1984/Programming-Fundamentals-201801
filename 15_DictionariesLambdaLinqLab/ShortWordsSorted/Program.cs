using System;
using System.Linq;
using System.Collections.Generic;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', '[', '\"', '\'', '/', '\\', '!', '?', ' ' };
            string[] words = Console.ReadLine()
                    .ToLower()
                    .Split(separators)
                    .Where(word => word != "")
                    .Where(word => word.Length < 5)
                    .Distinct()
                    .OrderBy(word => word)
                    .ToArray();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}
