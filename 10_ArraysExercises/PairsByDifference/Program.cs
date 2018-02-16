using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int element = 0; element < arrayInt.Length - 1; element++)
            {
                for (int subsequentElement = element + 1; subsequentElement < arrayInt.Length; subsequentElement++)
                {
                    if (Math.Abs(arrayInt[element] - arrayInt[subsequentElement]) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
