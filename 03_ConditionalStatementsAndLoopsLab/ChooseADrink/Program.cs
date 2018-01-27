using System;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string beverage = "";

            switch(profession)
            {
                case "Athlete":
                    beverage = "Water";
                    break;
                case "Businesswoman":
                case "Businessman":
                    beverage = "Coffee";
                    break;
                case "SoftUni Student":
                    beverage = "Beer";
                    break;
                default:
                    beverage = "Tea";
                    break;
            }

            Console.WriteLine(beverage);
        }
    }
}
