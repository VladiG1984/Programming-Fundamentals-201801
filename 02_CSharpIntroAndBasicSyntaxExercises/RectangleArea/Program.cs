using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal side1 = decimal.Parse(Console.ReadLine());
            decimal side2 = decimal.Parse(Console.ReadLine());
            //decimal area = side1 * side2;

            Console.WriteLine($"{side1 * side2:F2}");
        }
    }
}
