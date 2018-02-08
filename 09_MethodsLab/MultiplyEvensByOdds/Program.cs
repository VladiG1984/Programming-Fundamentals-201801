using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static int GetSumEvens(long num)
        {
            int sumEvens = 0;

            while (num != 0)
            {
                int remainder = (int)(num % 10);
                num = num / 10;
                if (remainder % 2 == 0)
                {
                    sumEvens += remainder;
                }
            }
            return sumEvens;
        }

        static int GetSumOdds(long num)
        {
            int sumOdds = 0;

            while (num != 0)
            {
                int remainder = (int)(num % 10);
                num = num / 10;
                if (remainder % 2 != 0)
                {
                    sumOdds += remainder;
                }
            }
            return sumOdds;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            int productEvensByOdds = GetSumEvens(number) * GetSumOdds(number);
            Console.WriteLine(productEvensByOdds);
        }
    }
}
