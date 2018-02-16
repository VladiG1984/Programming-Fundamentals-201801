using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool[] arrayPrimes = new bool[number + 1];

            for (int member = 0; member < number + 1; member++)
            {
                arrayPrimes[member] = true;
            }

            arrayPrimes[0] = arrayPrimes[1] = false;

            for (int pointer = 0; pointer < number; pointer++)
            {
                if (arrayPrimes[pointer] == true)
                {
                    for (int multiple = 2; pointer * multiple <= number; multiple++)
                    {
                        arrayPrimes[pointer * multiple] = false;
                    }
                }
            }

            for (int pointer = 0; pointer < number + 1; pointer++)
            {
                if (arrayPrimes[pointer] == true)
                {
                    Console.Write("{0} ", pointer);
                }
            }
            Console.WriteLine();
        }
    }
}
