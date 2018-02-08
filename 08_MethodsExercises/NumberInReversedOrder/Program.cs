using System;

namespace NumberInReversedOrder
{
    class Program
    {
        static void GetNumberInReversedOrder(string number)
        {
            string reversedNumber = "";

            for (int pointer = number.Length - 1; pointer >= 0; pointer--)
            {
                reversedNumber += number[pointer];
            }
            Console.WriteLine(reversedNumber);
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            GetNumberInReversedOrder(number);
        }
    }
}
