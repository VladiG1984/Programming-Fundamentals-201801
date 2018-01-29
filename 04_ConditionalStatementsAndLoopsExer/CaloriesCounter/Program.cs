using System;

namespace CaloriesCounter
{
    class Program
    {
        static int GetProductCalories(string product)
        {
            int productCalories = 0;

            switch (product)
            {
                case "cheese":
                    productCalories = 500;
                    break;
                case "tomato sauce":
                    productCalories = 150;
                    break;
                case "salami":
                    productCalories = 600;
                    break;
                case "pepper":
                    productCalories = 50;
                    break;
            }
            return productCalories;
        }

        static void Main(string[] args)
        {
            int numberIterations = int.Parse(Console.ReadLine());
            int totalCalories = 0;

            for (int i = 0; i < numberIterations; i++)
            {
                string product = Console.ReadLine().ToLower();

                totalCalories += GetProductCalories(product);
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
