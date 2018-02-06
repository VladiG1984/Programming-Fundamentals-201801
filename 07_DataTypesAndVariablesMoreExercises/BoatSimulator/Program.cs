using System;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int charFirstBoatInNumber = Convert.ToInt32(char.Parse(Console.ReadLine()));
            int charSecondBoatInNumber = Convert.ToInt32(char.Parse(Console.ReadLine()));

            sbyte numberOfLines = sbyte.Parse(Console.ReadLine());

            int totalPointsBoat1 = 0;
            int totalPointsBoat2 = 0;
            char winner = ' ';

            for (int line = 1; line <= numberOfLines; line++)
            {
                string lineText = Console.ReadLine();

                if (lineText == "UPGRADE")
                {
                    charFirstBoatInNumber += 3;
                    charSecondBoatInNumber += 3;
                }

                if (line % 2 != 0)
                {
                    totalPointsBoat1 += lineText.Length;

                }
                else
                {
                    totalPointsBoat2 += lineText.Length;
                }

                if (totalPointsBoat1 >= 50)
                {
                    winner = Convert.ToChar(charFirstBoatInNumber);
                    break;
                }

                if (totalPointsBoat2 >= 50)
                {
                    winner = Convert.ToChar(charSecondBoatInNumber);
                    break;
                }
            }

            if (totalPointsBoat1 < 50 && totalPointsBoat2 < 50)
            {
                if (totalPointsBoat1 > totalPointsBoat2)
                {
                    Console.WriteLine(Convert.ToChar(charFirstBoatInNumber));
                }
                else
                {
                    Console.WriteLine(Convert.ToChar(charSecondBoatInNumber));
                }
            }
            else
            {
                Console.WriteLine(winner);
            }
        }
    }
}
