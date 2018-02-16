using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayDouble = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToArray();
            int[] arrayInt = new int[arrayDouble.Length];
            int counter = 0;

            foreach (double numberDouble in arrayDouble)
            {
                arrayInt[counter] = (int)Math.Round(numberDouble, 0, MidpointRounding.AwayFromZero);
                counter++;
            }

            for (int pointer = 0; pointer < arrayDouble.Length; pointer++)
            {
                Console.WriteLine("{0} => {1}", arrayDouble[pointer], arrayInt[pointer]);
            }


        }
    }
}
