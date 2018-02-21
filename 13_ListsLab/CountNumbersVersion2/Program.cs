using System;
using System.Linq;
using System.Collections.Generic;

namespace CountNumbers_Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            numbers.Sort();
            int count = 0;

            for (int position = 0; position < numbers.Count(); position++)
            {
                decimal num = numbers[position];
                count = 1;

                for (int i = position + 1; i < numbers.Count; i++)
                {
                    if(numbers[i] == num)
                    {
                        count++;
                        position++;
                    }
                }
                Console.WriteLine("{0} -> {1}", num, count);
            }
        }
    }
}
