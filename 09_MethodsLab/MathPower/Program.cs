using System;

namespace MathPower
{
    class Program
    {
        static double RaiseToPower(double number, double power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}", Math.Pow(number, power));
        }
    }
}
