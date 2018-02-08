using System;

namespace HelloName
{
    class Program
    {
        static void PrintHelloName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            PrintHelloName();
        }
    }
}
