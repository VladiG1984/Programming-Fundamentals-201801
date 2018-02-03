using System;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            double diagonal1 = width * width + height * height;
            double diagonal = Math.Sqrt(diagonal1);

            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");
        }
    }
}
