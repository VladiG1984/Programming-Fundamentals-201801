using System;
using System.Numerics;

namespace FactorialTrailingZeros
{
    class Program
    {
        static BigInteger GetFactorial(short number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            //Console.WriteLine("factorial = " + factorial);
            return factorial;
        }

        static void GetTrailingZeros(short number)
        {
            BigInteger factorial = GetFactorial(number);

            short count = -1;
            int remainder = 0;

            while (remainder == 0)
            {
                remainder = (int)(factorial % 10);
                factorial = factorial / 10;
                count++;
                //Console.WriteLine("remainder: " + remainder);
            }
            Console.WriteLine(count); ;
        }

        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());

            GetTrailingZeros(number);

        }
    }
}
