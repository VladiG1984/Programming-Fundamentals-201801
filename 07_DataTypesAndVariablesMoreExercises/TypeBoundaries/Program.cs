using System;

namespace TypeBoundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long maxNumber = 0;
            long minNumber = 0;

            switch (number)
            {
                case "byte":
                    maxNumber = byte.MaxValue;
                    minNumber = byte.MinValue;
                    break;
                case "sbyte":
                    maxNumber = sbyte.MaxValue;
                    minNumber = sbyte.MinValue;
                    break;
                case "int":
                    maxNumber = int.MaxValue;
                    minNumber = int.MinValue;
                    break;
                case "uint":
                    maxNumber = uint.MaxValue;
                    minNumber = uint.MinValue;
                    break;
                case "long":
                    maxNumber = long.MaxValue;
                    minNumber = long.MinValue;
                    break;
            }
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
        }
    }
}
