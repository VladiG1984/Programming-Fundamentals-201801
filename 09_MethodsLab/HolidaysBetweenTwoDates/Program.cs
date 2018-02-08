using System;
using System.Globalization;

namespace HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture); 
            // d.M.yyyy reads double or single days, double or single months
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            
            var holidaysCount = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                //date = date.AddDays(1) increments date with one day; should be assigned to date 
                //because method AddDay() throws in a new instance; else code won't work
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
