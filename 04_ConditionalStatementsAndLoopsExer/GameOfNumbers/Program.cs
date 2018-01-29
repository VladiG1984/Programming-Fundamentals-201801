using System;

namespace GameOfNumbers
{
    class Program
    {
        static int getMinNumber (int n, int m)
        {
            int minNumber = Math.Min(n, m);
            return minNumber;
        }

        static int getMaxNumber(int n, int m)
        {
            int maxNumber = Math.Max(n, m);
            return maxNumber;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int minNumber = getMinNumber(n, m);
            int maxNumber = getMaxNumber(n, m);

            int counter = 0;
            string magicCombination = "";

            if (minNumber >= 1 && minNumber <= 999 && maxNumber >= minNumber && maxNumber <= 1000 &&
                        magicNumber >= 1 && magicNumber <= 10000)
            {
                for (int i = minNumber; i <= maxNumber; i++)
                {
                    for (int j = minNumber; j <= maxNumber; j++)
                    {
                        if (i + j == magicNumber)
                        {
                            magicCombination = i + " + " + j;
                        }
                        counter++;
                    }
                }
                if (magicCombination != "")
                {
                    Console.WriteLine($"Number found! {magicCombination} = {magicNumber}");
                }
                else
                {
                    Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
                }
            }
        }
    }
}
