using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            string weatherForecast = "";

            long number;

            if (long.TryParse(numberString, out number))
            {
                number = long.Parse(numberString);

                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    weatherForecast = "Sunny";
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    weatherForecast = "Cloudy";
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    weatherForecast = "Windy";
                }
            }
            else
            {
                float numberFloat;

                if (float.TryParse(numberString, out numberFloat))
                {
                    weatherForecast = "Rainy";
                }
            }
            
            Console.WriteLine(weatherForecast);
        }
    }
}
