using System;

namespace CircleAreaPrecision12
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double circleArea = r * r * Math.PI;
            Console.WriteLine("{0:F12}", circleArea);
        }
    }
}
