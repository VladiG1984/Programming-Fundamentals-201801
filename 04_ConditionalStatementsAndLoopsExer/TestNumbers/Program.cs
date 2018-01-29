using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int result = 0;
            bool isBoundaryExceeded = false;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    result += 3 * (i * j);
                    counter++;
                    if(result >= boundary)
                    {
                        isBoundaryExceeded = true;
                        break;
                    }
                }
                if (isBoundaryExceeded == true)
                {
                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {result} >= {boundary}");
                    break;
                }
            }
            if (isBoundaryExceeded == false)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {result}");
            }
        }
    }
}
