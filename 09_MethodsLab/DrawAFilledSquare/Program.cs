using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void PrintHeaderFooter(int n)
        {
            for (int col = 0; col < 2 * n; col++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void PrintBody(int n)
        {
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("-");
                for (int col = 0; col < n - 1; col++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);
            PrintBody(n);
            PrintHeaderFooter(n);
        }
    }
}
