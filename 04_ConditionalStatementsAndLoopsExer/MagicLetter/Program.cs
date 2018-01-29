using System;

namespace MagicLetter
{
    class Program
    {
        static char GetMinLetter(char letter1, char letter2)
        {
            if (letter1.CompareTo(letter2) > 0)
            {
                return letter2;
            }
            else
            {
                return letter1;
            }
        }

        static char GetMaxLetter(char letter1, char letter2)
        {
            if (letter1.CompareTo(letter2) > 0)
            {
                return letter1;
            }
            else
            {
                return letter2;
            }
        }

        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letterToExclude = char.Parse(Console.ReadLine());

            char minLetter = GetMinLetter(letter1, letter2);
            char maxLetter = GetMaxLetter(letter1, letter2);

            for (char i = minLetter; i <= maxLetter; i++)
            {
                for (char j = minLetter; j <= maxLetter; j++)
                {
                    for (char k = minLetter; k <= maxLetter; k++)
                    {
                        if (letterToExclude.Equals(i) || letterToExclude.Equals(j) ||
                                    letterToExclude.Equals(k))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
