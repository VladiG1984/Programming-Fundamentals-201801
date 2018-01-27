using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int repeat = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{number} X {repeat} = {number * repeat}");
                repeat++;
            } while (repeat <= 10);
        }
    }
}
