using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            long numberInteger;
            bool isInteger = Int64.TryParse(number, out numberInteger);
            
            if (isInteger)
            {
                Console.WriteLine("integer");
            }
            else
            {
                double numberDouble;
                bool isDouble = Double.TryParse(number, out numberDouble);

                if (isDouble)
                {
                    Console.WriteLine("floating-point");
                }
                else
                {
                    Console.WriteLine("not a number");
                }
            }
        }
    }
}
