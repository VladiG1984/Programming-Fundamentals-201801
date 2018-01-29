using System;

namespace Hotel
{
    class Program
    {
        static int DeterminePricePerNightStudio(string month)
        {
            int pricePerNightStudio = 0;

            switch (month)
            {
                case "may":
                case "october":
                    pricePerNightStudio = 50;
                    break;
                case "june":
                case "september":
                    pricePerNightStudio = 60;
                    break;
                case "july":
                case "august":
                case "december":
                    pricePerNightStudio = 68;
                    break;
            }
            return pricePerNightStudio;
        }

        static int DeterminePricePerNightDouble(string month)
        {
            int pricePerNightDouble = 0;

            switch (month)
            {
                case "may":
                case "october":
                    pricePerNightDouble = 65;
                    break;
                case "june":
                case "september":
                    pricePerNightDouble = 72;
                    break;
                case "july":
                case "august":
                case "december":
                    pricePerNightDouble = 77;
                    break;
            }
            return pricePerNightDouble;
        }

        static int DeterminePricePerNightSuite(string month)
        {
            int pricePerNightSuite = 0;

            switch (month)
            {
                case "may":
                case "october":
                    pricePerNightSuite = 75;
                    break;
                case "june":
                case "september":
                    pricePerNightSuite = 82;
                    break;
                case "july":
                case "august":
                case "december":
                    pricePerNightSuite = 89;
                    break;
            }
            return pricePerNightSuite;
        }

        static decimal CalculateDiscountStudio(string month, int nightsCount)
        {
            decimal discountStudio = 0m;

            if ((month == "may" || month == "october") && nightsCount > 7)
            {
                discountStudio = 0.05m;
            }
            return discountStudio;
        }

        static int DetermineOneNightFreeStudio(string month, int nightsCount)
        {
            int freeNights = 0;

            if ((month == "september" || month == "october") && nightsCount > 7)
            {
                freeNights = 1;
            }
            return freeNights;
        }

        static decimal CalculateDiscountDouble(string month, int nightsCount)
        {
            decimal discountDouble = 0m;

            if ((month == "june" || month == "september") && nightsCount > 14)
            {
                discountDouble = 0.1m;
            }
            return discountDouble;
        }

        static decimal CalculateDiscountSuite(string month, int nightsCount)
        {
            decimal discountSuite = 0m;

            if ((month == "july" || month == "august" || month == "december") && nightsCount > 14)
            {
                discountSuite = 0.15m;
            }
            return discountSuite;
        }

        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightsCount = int.Parse(Console.ReadLine());

            decimal totalPriceStudio = (decimal)(nightsCount - DetermineOneNightFreeStudio(month, nightsCount)) *
                    DeterminePricePerNightStudio(month) * (1 - CalculateDiscountStudio(month, nightsCount));

            decimal totalPriceDouble = (decimal)(nightsCount * DeterminePricePerNightDouble(month)) *
                    (1 - CalculateDiscountDouble(month, nightsCount));

            decimal totalPriceSuite = (decimal)(nightsCount * DeterminePricePerNightSuite(month)) *
                    (1 - CalculateDiscountSuite(month, nightsCount));

            if (nightsCount > 0 && nightsCount <= 200 &&
                    (month == "may" || month == "june" || month == "july" || month == "august" ||
                            month == "september" || month == "october" || month == "december"))
            {
                Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
                Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
                Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");
            }
        }
    }
}
