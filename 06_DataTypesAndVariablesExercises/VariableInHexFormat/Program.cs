using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexFormatNumber = Console.ReadLine();

            int intNumber = Convert.ToInt32(hexFormatNumber, 16);
            Console.WriteLine($"{intNumber}");

        }
    }
}
