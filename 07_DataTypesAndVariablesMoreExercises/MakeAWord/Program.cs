using System;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfLetters = sbyte.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < numberOfLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
