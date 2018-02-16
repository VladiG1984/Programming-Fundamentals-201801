using System;
using System.Linq;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());
            int lastPosition = 0;
            long sum = 0;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] == number)
                {
                    lastPosition = i;
                }
            }

            for (int i = 0; i < lastPosition; i++)
            {
                sum += arrayInt[i];
            }

            if (lastPosition == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
