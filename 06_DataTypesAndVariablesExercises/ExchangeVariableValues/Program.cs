using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            int oldA = a;
            a = b;
            b = oldA;

            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
