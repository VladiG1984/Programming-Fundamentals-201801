using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "";

            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet += i + " ";
            }

            char[] arrayAlphabet = alphabet.Trim().Split(' ').Select(char.Parse).ToArray();

            //char[] arrayChar = Console.ReadLine().Trim().Split(' ').Select(char.Parse).ToArray();

            string arrayChar = Console.ReadLine();

            // Match characters from console input with characters from English alphabet and print position of
            // each of the input characters.

            for (int pointer = 0; pointer < arrayChar.Length; pointer++)
            {
                for (int element = 0; element < arrayAlphabet.Length; element++)
                {
                    if (arrayChar[pointer] == arrayAlphabet[element])
                    {
                        Console.WriteLine($"{arrayChar[pointer]} -> {element}");
                    }
                }
            }

        }
    }
}
