using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());

            string integerHex = Convert.ToString(integer, 16).ToUpper();
            string integerBinary = Convert.ToString(integer, 2);

            Console.WriteLine($"{integerHex}\n{integerBinary}");
        }
    }
}
