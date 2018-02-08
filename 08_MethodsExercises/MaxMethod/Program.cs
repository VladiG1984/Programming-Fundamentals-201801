using System;

namespace MaxMethod
{
    class Program
    {
        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int biggestNumber = GetMax(GetMax(number1, number2), number3);
            Console.WriteLine(biggestNumber);
        }
    }
}
