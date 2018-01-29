using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            if (startNumber > endNumber)
            {
                int bufferNumber = startNumber;
                startNumber = endNumber;
                endNumber = bufferNumber;
            }

            if (startNumber < endNumber && startNumber >= 0 && startNumber <= 100 &&
                        endNumber >= 0 && endNumber <= 100)
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
