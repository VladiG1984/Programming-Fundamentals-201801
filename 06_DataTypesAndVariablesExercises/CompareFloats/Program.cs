using System;

namespace CompareFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool areEqual = Math.Abs(number1 - number2) < eps;

            Console.WriteLine(areEqual);
            //Console.WriteLine(Math.Abs(number1 - number2));
        }
    }
}
