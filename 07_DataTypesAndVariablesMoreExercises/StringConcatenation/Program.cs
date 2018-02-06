using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string sequence = Console.ReadLine();
            sbyte numberOfStrings = sbyte.Parse(Console.ReadLine());

            string textSequence = "";

            for (int i = 1; i <= numberOfStrings; i++)
            {
                string word = Console.ReadLine();

                if (sequence == "even")
                {
                    if (i % 2 == 0)
                    {
                        textSequence += delimiter + word;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        textSequence += delimiter + word;
                    }
                }
            }
            Console.WriteLine(textSequence.Remove(0, 1));
        }
    }
}
