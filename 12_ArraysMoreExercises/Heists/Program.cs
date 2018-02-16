using System;
using System.Linq;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceJewelGold = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            string[] loot = new string[2];

            long earningsJewel = 0;
            long earningsGold = 0;
            long expense = 0;

            while (loot[0] + " " + loot[1] != "Jail Time")
            {
                loot = Console.ReadLine().Trim().Split(' ').ToArray();

                for (int i = 0; i < loot[0].Length; i++)
                {
                    if (loot[0][i] == '%')
                    {
                        earningsJewel += priceJewelGold[0];
                    }
                    else if (loot[0][i] == '$')
                    {
                        earningsGold += priceJewelGold[1];
                    }
                }

                if (loot[1] != "Time")
                {
                    expense += int.Parse(loot[1]);
                }
            }

            if (earningsJewel + earningsGold >= expense)
            {
                Console.WriteLine("Heists will continue. Total earnings: {0}.", 
                        (earningsJewel + earningsGold) - expense);
            } else
            {
                Console.WriteLine("Have to find another job. Lost: {0}.", 
                        expense - (earningsJewel + earningsGold));
            }
        }
    }
}
