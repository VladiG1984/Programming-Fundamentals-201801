using System;

namespace ColoriesCounter
{
    class Program
    {
        static int GetProductCalories(string product)
        {
            int productColories = 0;

            switch (product)
            {
                case "cheese":
                    productColories = 500;
                    break;
                case "tomato sauce":
                    productCalories
            }
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
        }
    }
}
