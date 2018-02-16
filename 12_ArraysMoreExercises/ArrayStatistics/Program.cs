using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int minVal = int.MaxValue;
            int maxVal = int.MinValue;
            int sumVal = 0;
            int count = 0;
            
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < minVal)
                {
                    minVal = arrayInt[i];
                }

                if (arrayInt[i] > maxVal)
                {
                    maxVal = arrayInt[i];
                }

                sumVal += arrayInt[i];
                count++;
            }

            double avVal = (double)sumVal / count;

            Console.WriteLine("Min = {0}", minVal);
            Console.WriteLine("Max = {0}", maxVal);
            Console.WriteLine("Sum = {0}", sumVal);
            Console.WriteLine("Average = {0}", avVal);
        }
    }
}
