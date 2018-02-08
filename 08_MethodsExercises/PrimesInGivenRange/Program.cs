using System;

namespace PrimesInGivenRange
{
    class Program
    {
        static void FindPrimesInRange(int startNum, int endNum)
        {
            string output = "";

            for (int number = startNum; number <= endNum; number++)
            {
                bool isPrime = true;
                if (number == 0 || number == 1)
                {
                    isPrime = false;
                }
                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    output += ", " + number;
                }
            }
            Console.WriteLine(output.Remove(0,2));
        }

        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            FindPrimesInRange(startNum, endNum);
        }
    }
}
