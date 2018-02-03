using System;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLimit = int.Parse(Console.ReadLine());
            for (int checkPrime = 2; checkPrime <= numberLimit; checkPrime++)
            {
                bool isPrime = true;
                for (int divisor = 2; divisor <= Math.Sqrt(checkPrime); divisor++)
                {
                    if (checkPrime % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{checkPrime} -> {isPrime}");
            }

        }
    }
}
