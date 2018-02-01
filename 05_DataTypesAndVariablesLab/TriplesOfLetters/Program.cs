using System;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLetters = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLetters; i++)
            {
                char letter1 = (char)('a' + i);

                for (int j = 0; j < numberLetters; j++)
                {
                    char letter2 = (char)('a' + j);

                    for (int k = 0; k < numberLetters; k++)
                    {
                        char letter3 = (char)('a' + k);

                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
