using System;

namespace TemperatureConversion
{
    class Program
    {
        static double GetCelsiusDeg(double fahrenheitDeg)
        {
            double celsiusDeg = (fahrenheitDeg - 32) * 5 / 9;
            return celsiusDeg;
        }

        static void Main(string[] args)
        {
            double fahrenheitDeg = double.Parse(Console.ReadLine());

            double celsiusDeg = GetCelsiusDeg(fahrenheitDeg);
            Console.WriteLine($"{celsiusDeg:F2}");
        }
    }
}
