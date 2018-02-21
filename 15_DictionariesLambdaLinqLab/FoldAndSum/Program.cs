using System;
using System.Linq;
using System.Collections.Generic;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers4K = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int K = integers4K.Length / 4;

            int[] integers2KLeft = integers4K
                    .Take(K)
                    .Reverse()
                    .ToArray();

            int[] integers2KRight = integers4K
                    .Skip(3 * K)
                    .Take(K)
                    .Reverse()
                    .ToArray();

            int[] row1 = integers2KLeft.Concat(integers2KRight).ToArray();

            int[] row2 = integers4K
                    .Skip(K)
                    .Take(2 * K)
                    .ToArray();

            // Version 1: Sum the elements of the two rows together using Linq functions:
            int[] arraySum = row1
                    .Select((x, index) => x + row2[index])
                    .ToArray();

            // Version 2: Sum the elements of the two rows together using a loop:
            //int[] arraySum = new int[2 * K];

            //for (int i = 0; i < 2 * K; i++)
            //{
            //    arraySum[i] = row1[i] + row2[i];
            //}
            Console.WriteLine(String.Join(" ", arraySum));
        }
    }
}
