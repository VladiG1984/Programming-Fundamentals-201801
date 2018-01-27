using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string debitCardNumber = "";

            for (int i = 0; i < 4; i++)
            {
                int number = int.Parse(Console.ReadLine());
                debitCardNumber += number.ToString().PadLeft(4, '0') + " ";
            }
            Console.WriteLine(debitCardNumber);
        }
    }
}
