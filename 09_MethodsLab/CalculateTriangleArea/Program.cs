using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static double GetTriangleArea(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double triangleArea = GetTriangleArea(side, height);

            Console.WriteLine(triangleArea);
        }
    }
}
