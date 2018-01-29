using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static decimal CalculatePriceOfDrink(int quantity, decimal pricePerUnit)
        {
            decimal price = quantity * pricePerUnit;
            return price;
        }

        static string DetermineDrink(string profession)
        {
            string drink = "Tea";

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businesswoman":
                case "Businessman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
            }
            return drink;
        }

        static decimal DeterminePricePerUnit(string drink)
        {
            decimal pricePerUnit = 1.2m;

            switch (drink)
            {
                case "Water":
                    pricePerUnit = 0.7m;
                    break;
                case "Coffee":
                    pricePerUnit = 1m;
                    break;
                case "Beer":
                    pricePerUnit = 1.7m;
                    break;
            }
            return pricePerUnit;
        }

        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = DetermineDrink(profession);

            decimal pricePerUnit = DeterminePricePerUnit(drink);

            decimal totalPrice = CalculatePriceOfDrink(quantity, pricePerUnit);

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
