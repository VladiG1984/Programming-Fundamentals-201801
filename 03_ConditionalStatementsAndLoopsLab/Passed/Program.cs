using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            float score = float.Parse(Console.ReadLine());

            if (score >= 3)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
