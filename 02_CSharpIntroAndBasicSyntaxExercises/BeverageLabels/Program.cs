using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{energyContent * (double)volume / 100}kcal, " +
                $"{sugarContent * (double)volume / 100}g sugars");
        }
    }
}
