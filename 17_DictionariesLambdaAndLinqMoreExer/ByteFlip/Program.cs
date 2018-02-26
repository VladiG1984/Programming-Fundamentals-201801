using System;
using System.Linq;
using System.Collections.Generic;

namespace ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hexString = Console.ReadLine().Split(' ').ToArray();

            hexString = hexString.Where(x => x.Length == 2).ToArray();

            for (int i = 0; i < hexString.Length; i++)
            {
                string results = "";
                foreach (char item in hexString[i])
                {
                    results = item + results;
                }
                hexString[i] = results;
            }
            Array.Reverse(hexString);

            char[] hexChar = hexString.Select(x => Convert.ToChar(Convert.ToInt32(x, 16))).ToArray();
            Console.WriteLine(String.Join("", hexChar));

            // This is the much better way to write the code (not mine):
            //var messageCode = Console.ReadLine()
            //    .Split(' ')
            //    .Where(x => x.Length == 2)
            //    .Select(x => new string(x.Reverse().ToArray()))
            //    .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
            //    .Reverse()
            //    .ToList();
            //Console.WriteLine(string.Join(null, messageCode));
        }
    }
}
