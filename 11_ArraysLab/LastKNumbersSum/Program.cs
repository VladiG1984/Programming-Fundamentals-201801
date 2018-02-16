using System;

namespace LastKNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());
            int numberOfIntInCal = int.Parse(Console.ReadLine());

            long[] arrayInt = new long[numberOfIntegers];

            // First element in array is set to 1
            arrayInt[0] = 1;

            // Calculate following elements (each one of their values equals sum)
            for (int arrayPointer = 1; arrayPointer < numberOfIntegers; arrayPointer++)
            {
                long sum = 0;

                // Loop through the k (numberOfIntInCal) previous elements, 
                // summing them to get value of current element (arrayPointer)
                for (int intCalc = arrayPointer - 1; intCalc >= arrayPointer - numberOfIntInCal; intCalc--)
                {
                    if (intCalc >= 0)
                    {
                        sum += arrayInt[intCalc];
                    }
                    else
                    {
                        break;
                    }
                }
                arrayInt[arrayPointer] = sum;
            }

            //Print array
            foreach(long number in arrayInt)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
