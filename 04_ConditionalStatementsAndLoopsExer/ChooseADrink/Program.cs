using System;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
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
            Console.WriteLine(drink);
        }
    }
}
