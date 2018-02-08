using System;

namespace PrintTriangle
{
    class Program
    {
        static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n - 1; i++)
            {
                PrintLine(i);
            }

            PrintLine(n);

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
    }
}
