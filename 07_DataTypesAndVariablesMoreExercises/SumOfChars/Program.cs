using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfCharacters = sbyte.Parse(Console.ReadLine());
            int sumOfCharacters = 0;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sumOfCharacters += Convert.ToInt32(character);
            }
            Console.WriteLine($"The sum equals: {sumOfCharacters}");
        }
    }
}
