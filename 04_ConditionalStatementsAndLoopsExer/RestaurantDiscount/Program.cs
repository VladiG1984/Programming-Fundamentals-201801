using System;

namespace RestaurantDiscount
{
    class Program
    {
        static string DetermineHall(int groupSize)
        {
            string hall = "none";

            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hall = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hall = "Great Hall";
            }
            return hall;
        }

        static int DeterminePriceOfHall(int groupSize)
        {
            int hallPrice = 0;

            if (groupSize > 0 && groupSize <= 50)
            {
                hallPrice = 2500;
            }
            else if (groupSize <= 100)
            {
                hallPrice = 5000;
            }
            else if (groupSize <= 120)
            {
                hallPrice = 7500;
            }
            return hallPrice;
        }

        static decimal DeterminePackageDiscount(string package)
        {
            decimal packageDiscount = 0m;

            switch (package)
            {
                case "Normal":
                    packageDiscount = 0.05m;
                    break;
                case "Gold":
                    packageDiscount = 0.1m;
                    break;
                case "Platinum":
                    packageDiscount = 0.15m;
                    break;
            }
            return packageDiscount;
        }

        static int DeterminePackagePrice(string package)
        {
            int packagePrice = 0;

            switch (package)
            {
                case "Normal":
                    packagePrice = 500;
                    break;
                case "Gold":
                    packagePrice = 750;
                    break;
                case "Platinum":
                    packagePrice = 1000;
                    break;
            }
            return packagePrice;
        }

        static decimal CalculatePricePerPerson(int groupSize, int hallPrice, int packagePrice, 
            decimal packageDiscount)
        {
            decimal pricePerPerson = (decimal)(hallPrice + packagePrice) * (1 - packageDiscount) / 
                    groupSize;
            return pricePerPerson;
        }
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall = DetermineHall(groupSize);
            int hallPrice = DeterminePriceOfHall(groupSize);
            decimal packageDiscount = DeterminePackageDiscount(package);
            int packagePrice = DeterminePackagePrice(package);
            decimal pricePerPerson = CalculatePricePerPerson(groupSize, hallPrice, packagePrice,
                    packageDiscount);

            if (groupSize <= 120)
            {
                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:F2}$", pricePerPerson);
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            

        }
    }
}
