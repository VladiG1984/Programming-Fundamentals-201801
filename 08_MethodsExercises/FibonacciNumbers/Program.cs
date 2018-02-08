using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void GetFibonacciNumber(int numberPointer)
        {
            int oldNumber = 1;
            int currentNumber = 0;
            int fibonacciNumber = oldNumber + currentNumber;

            for (int i = 1; i < numberPointer; i++)
            {
                currentNumber = fibonacciNumber;
                fibonacciNumber = oldNumber + currentNumber;

                oldNumber = currentNumber;

            }
            Console.WriteLine(fibonacciNumber);
        }
        static void Main(string[] args)
        {
            int numberPointer = int.Parse(Console.ReadLine());

            GetFibonacciNumber(numberPointer);
        }
    }
}
