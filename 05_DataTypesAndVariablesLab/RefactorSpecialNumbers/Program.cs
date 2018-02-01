using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            
            for (int number = 1; number <= quantity; number++)
            {
                bool isSpecialNumber = false;
                int sumDigits = 0;
                int numberToExplore = number;

                while (number > 0)
                {
                    sumDigits += number % 10;
                    number = number / 10;
                }

                isSpecialNumber = (sumDigits == 5) || (sumDigits == 7) || (sumDigits == 11);
                Console.WriteLine($"{numberToExplore} -> {isSpecialNumber}");
                number = numberToExplore;
            }

        }
    }
}
