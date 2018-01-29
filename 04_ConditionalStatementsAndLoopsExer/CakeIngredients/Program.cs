using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberIngredients = 0;

            while (true)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                numberIngredients++;
            }
            Console.WriteLine($"Preparing cake with {numberIngredients} ingredients.");
        }
    }
}
