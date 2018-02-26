using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string dateInput = Console.ReadLine();

            DateTime dateOutput = DateTime.ParseExact(dateInput, "d-M-yyyy", CultureInfo.InvariantCulture);

            //string weekday = dateOutput.DayOfWeek.ToString();
            // var weekday = dateOutput.DayOfWeek;

            Console.WriteLine(dateOutput.DayOfWeek);
            
            //Console.WriteLine("year: {0}, month: {1}, day: {2}; {3}", dateOutput.Year, dateOutput.Month, dateOutput.Day, dateOutput.DayOfWeek);
        }
    }
}
