using System;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            decimal imperialValue = decimal.Parse(Console.ReadLine());
            decimal metricValue = 0M;
            string metricUnit = "";

            switch(imperialUnit)
            {
                case "miles":
                    metricValue = imperialValue * 1.6M;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    metricValue = imperialValue * 2.54M;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    metricValue = imperialValue * 30M;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    metricValue = imperialValue * 0.91M;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    metricValue = imperialValue * 3.8M;
                    metricUnit = "liters";
                    break;
            }
            Console.WriteLine($"{imperialValue} {imperialUnit} = {metricValue:F2} {metricUnit}");
        }
    }
}
