using System;

namespace PassedOrFailed
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
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
