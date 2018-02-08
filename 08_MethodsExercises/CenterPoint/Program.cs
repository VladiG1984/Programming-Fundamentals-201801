using System;

namespace CenterPoint
{
    class Program
    {
        static double GetDistanceToCenter(double x, double y)
        {
            double distanceToCenter = Math.Sqrt(x * x + y * y);
            //Console.WriteLine(distanceToCenter);
            return distanceToCenter;
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distanceToCenter1 = GetDistanceToCenter(x1, y1);
            double distanceToCenter2 = GetDistanceToCenter(x2, y2);

            if (distanceToCenter1 <= distanceToCenter2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
