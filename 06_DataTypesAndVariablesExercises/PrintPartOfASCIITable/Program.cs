using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endChar = int.Parse(Console.ReadLine());

            for (int charValue = startChar; charValue <= endChar; charValue++)
            {
                Console.Write(Convert.ToChar(charValue));
            }
            Console.WriteLine();
        }
    }
}
