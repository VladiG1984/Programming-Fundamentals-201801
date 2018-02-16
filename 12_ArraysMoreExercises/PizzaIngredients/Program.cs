using System;
using System.Linq;

namespace PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredientsList = Console.ReadLine().Trim().Split(' ').ToArray();
            int ingredientLength = int.Parse(Console.ReadLine());
            int ingredientsSum = 0;

            string[] ingredientsListFinal = new string[ingredientsList.Length];
            
            for (int i = 0; i < ingredientsList.Length; i++)
            {
                if (ingredientsList[i].Length == ingredientLength)
                {
                    ingredientsListFinal[ingredientsSum] = ingredientsList[i];
                                        
                    Console.WriteLine("Adding {0}.", ingredientsList[i]);
                    ingredientsSum++;
                    if (ingredientsSum == 10)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Made pizza with total of {0} ingredients.", ingredientsSum);

            Console.Write("The ingredients are: ");
            // Remove duplicates and null values from final array containing ingredients that are part of the
            // meal.
            //ingredientsListFinal = ingredientsListFinal.Where(x => !string.IsNullOrEmpty(x)).Distinct().ToArray();
            
            for (int i = 0; i < ingredientsSum; i++)
            {
                if (i < ingredientsSum - 1)
                {
                    Console.Write("{0}, ", ingredientsListFinal[i]);
                }
                else
                {
                    Console.WriteLine("{0}.", ingredientsListFinal[i]);
                }
            }

        }
    }
}
