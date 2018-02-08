using System;

namespace PrimeChecker
{
    class Program
    {
        static void IsPrime(long number)
        {
            bool isPrimeNumber = true;

            if (number == 0 || number == 1)
            {
                isPrimeNumber = false;
                Console.WriteLine(isPrimeNumber);
                return;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }
            Console.WriteLine(isPrimeNumber);
        }
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            IsPrime(number);
        }
    }
}
