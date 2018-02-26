using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace CountWorkingDays
{
    class CountWorkdingDays
    {
        static void Main(string[] args)
        {
            // Import from console start and end dates
            string startDateRaw = Console.ReadLine();
            string endDateRaw = Console.ReadLine();

            // Parse dates in DateTime format
            DateTime startDate = DateTime.ParseExact(startDateRaw, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateRaw, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            // Create array containing holidays
            DateTime[] holidays =
            {
                DateTime.ParseExact("01-01-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2000", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            int countWorkDays = 0;

            // Check each day between start and end dates if it is a holiday or a weekend day
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                DateTime currentDate = date;
                bool isHoliday = false;

                // Check current day is a holiday
                foreach (DateTime holiday in holidays)
                {
                    int month = holiday.Month;
                    int day = holiday.Day;

                    if (month == currentDate.Month && day == currentDate.Day)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (isHoliday == true)
                {
                    continue;
                }

                // Check if current day is a weekend day
                if (currentDate.DayOfWeek.ToString() == "Saturday" || currentDate.DayOfWeek.ToString() == "Sunday")
                {
                    continue;
                }

                countWorkDays++;
            }

            Console.WriteLine(countWorkDays);
        }
    }
}
