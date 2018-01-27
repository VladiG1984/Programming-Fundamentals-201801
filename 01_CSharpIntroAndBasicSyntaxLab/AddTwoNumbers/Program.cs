using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        }
    }
}
