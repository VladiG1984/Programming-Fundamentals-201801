using System;

namespace GeometryCalculator
{
    class Program
    {
        static double GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = side * height / 2;
            return area;
        }

        static double GetSquareArea()
        {
            double side1 = double.Parse(Console.ReadLine());

            double area = side1 * side1;
            return area;
        }

        static double GetRectangleArea()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());

            double area = side1 * side2;
            return area;
        }

        static double GetCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            return area;
        }

        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double output = 0;

            if (figure == "triangle")
            {
                output = GetTriangleArea();
            }
            else if (figure == "square")
            {
                output = GetSquareArea();
            }
            else if (figure == "rectangle")
            {
                output = GetRectangleArea();
            }
            else if (figure == "circle")
            {
                output = GetCircleArea();
            }

            Console.WriteLine($"{output:F2}");
        }
    }
}
