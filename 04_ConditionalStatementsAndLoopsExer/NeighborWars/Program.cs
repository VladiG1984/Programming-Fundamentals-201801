using System;

namespace NeighborWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePowerPesho = int.Parse(Console.ReadLine());
            int damagePowerGosho = int.Parse(Console.ReadLine());
            int round = 1;

            int healthPesho = 100;
            int healthGosho = 100;


            while (true)
            {
                /* odd rounds - Pesho attacks*/
                if (round % 2 != 0)
                {
                    healthGosho = healthGosho - damagePowerPesho;

                    /* Gosho still alive*/
                    if (healthGosho > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to " +
                        $"{healthGosho} health.");
                    }

                    /* Gosho lost*/
                    else
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                }

                /* even rounds - Gosho attacks*/
                else
                {
                    healthPesho = healthPesho - damagePowerGosho;

                    /* Pesho still alive*/
                    if (healthPesho > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to " +
                        $"{healthPesho} health.");
                    }

                    /* Pesho lost*/
                    else
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                }

                if (round % 3 == 0)
                {
                    healthGosho = healthGosho + 10;
                    healthPesho = healthPesho + 10;
                }

                round++;
            }
        }
    }
}

