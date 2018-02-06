using System;

namespace DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte key = sbyte.Parse(Console.ReadLine());
            sbyte numberCharacters = sbyte.Parse(Console.ReadLine());
            string wordDecrypted = "";

            for (int letter = 0; letter < numberCharacters; letter++)
            {
                char character = char.Parse(Console.ReadLine());

                char characterDecrypted = Convert.ToChar(Convert.ToInt32(character) + key);
                wordDecrypted += characterDecrypted;
            }
            Console.WriteLine(wordDecrypted);
        }
    }
}
