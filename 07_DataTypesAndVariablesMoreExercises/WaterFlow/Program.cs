using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte iterations = byte.Parse(Console.ReadLine());
            short sumLiters = 0;

            for (int i = 0; i < iterations; i++)
            {
                short liters = short.Parse(Console.ReadLine());

                if (sumLiters + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    sumLiters += liters;
                }
            }
            Console.WriteLine(sumLiters);
        }
    }
}
