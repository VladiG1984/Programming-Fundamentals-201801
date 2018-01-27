using System;

namespace CharacterStats
{
    class Program
    {
        static string PrintCurrentToMaxState(int current, int max)
        {
            string currentToMaxState = '|' + new string('|', current) +
                    new string('.', max - current) + '|';
            return currentToMaxState;
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: " + PrintCurrentToMaxState(currentHealth, maxHealth));
            Console.WriteLine("Energy: " + PrintCurrentToMaxState(currentEnergy, maxEnergy));
        }
    }
}
