using System;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", n);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSign(n);
        }
    }
}
