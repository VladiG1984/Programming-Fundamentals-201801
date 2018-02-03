using System;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedChars = "";

            for (int i = 0; i < 3; i++)
            {
                char character = char.Parse(Console.ReadLine());
                reversedChars = character + reversedChars;
            }
            Console.WriteLine(reversedChars);
        }
    }
}
