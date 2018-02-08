using System;

namespace CubeProperties
{
    class Program
    {
        static double GetLengthOfFaceDiagonal(double side)
        {
            double faceDiagonal = Math.Sqrt(Math.Pow(side, 2) + Math.Pow(side, 2));
            return faceDiagonal;
        }

        static double GetLengthOfSpaceDiagonal(double side)
        {
            double spaceDiagonal = Math.Sqrt(Math.Pow(side, 2) +
                    Math.Pow(GetLengthOfFaceDiagonal(side), 2));
            return spaceDiagonal;
        }

        static double GetVolume(double side)
        {
            double volume = side * side * side;
            return volume;
        }

        static double GetSurfaceArea(double side)
        {
            double surfaceArea = 6 * side * side;
            return surfaceArea;
        }

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double output = 0;

            if (parameter == "face")
            {
                output = GetLengthOfFaceDiagonal(side);
            }
            else if (parameter == "space")
            {
                output = GetLengthOfSpaceDiagonal(side);
            }
            else if (parameter == "volume")
            {
                output = GetVolume(side);
            }
            else if (parameter == "area")
            {
                output = GetSurfaceArea(side);
            }
            Console.WriteLine($"{output:F2}");
        }
    }
}
