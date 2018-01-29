using System;

namespace FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int bufferNumber = a;
                a = b;
                b = bufferNumber;
            }

            if (b >= a + 5)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = i + 1; j <= b; j++)
                    {
                        for (int k = j + 1; k <= b; k++)
                        {
                            for (int l = k + 1; l <= b; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
