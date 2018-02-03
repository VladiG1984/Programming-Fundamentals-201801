using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int totalTimeInSec = hours * 3600 + minutes * 60 + seconds;

            //Console.WriteLine(totalTimeInSec);
            //Console.WriteLine((3600F / 1000F));
            float speedMPS = (float)meters / totalTimeInSec;
            double speedKPH = (3600F / 1000F) * speedMPS;
            double speedMPH = speedKPH * 0.62150406473F;

            Console.WriteLine($"{speedMPS}\n{speedKPH}\n{speedMPH}");
        }
    }
}
