using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> defeatedVirusesList = new List<string>();
            int initialHealth = int.Parse(Console.ReadLine());
            int currentHealth = initialHealth;

            while (currentHealth > 0)
            {
                string input = Console.ReadLine();

                if (input.Equals("end"))
                {
                    Console.WriteLine("Final Health: {0}", currentHealth);
                    break;
                }

                string virus = input;
                // Here we use the integer division as required by the problem's definition
                int virusStrength = virus.Sum(x => x) / 3;

                int timeToDefeatVirusSec = virusStrength * virus.Length;

                if (defeatedVirusesList.Contains(virus))
                {
                    timeToDefeatVirusSec /= 3;
                }
                else
                {
                    defeatedVirusesList.Add(virus);
                }

                Console.WriteLine("Virus {0}: {1} => {2} seconds", virus, virusStrength, timeToDefeatVirusSec);

                currentHealth -= timeToDefeatVirusSec;
                if (currentHealth <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }

                int minutesToDefeatVirus = timeToDefeatVirusSec / 60;
                int secondsToDefeatVirus = timeToDefeatVirusSec % 60;

                Console.WriteLine("{0} defeated in {1}m {2}s.", virus, minutesToDefeatVirus, secondsToDefeatVirus);
                Console.WriteLine("Remaining health: {0}", currentHealth);

                currentHealth = (int)Math.Min(currentHealth * 1.2, initialHealth);

            }
        }
    }
}
