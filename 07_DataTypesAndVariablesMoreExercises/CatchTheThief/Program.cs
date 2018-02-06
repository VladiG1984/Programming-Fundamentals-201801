using System;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralTypeOfThief = Console.ReadLine();
            byte numberOfNumeralIds = byte.Parse(Console.ReadLine());
            long minValue = 0L;
            long maxValue = 0L;

            switch(numeralTypeOfThief) {
                case "sbyte":
                    minValue = sbyte.MinValue;
                    maxValue = sbyte.MaxValue;
                    break;
                case "int":
                    minValue = int.MinValue;
                    maxValue = int.MaxValue;
                    break;
                case "long":
                    minValue = long.MinValue;
                    maxValue = long.MaxValue;
                    break;
            }

            long thiefNumeralId = 0;

            for (int i = 0; i < numberOfNumeralIds; i++)
            {
                long numeralId = long.Parse(Console.ReadLine());

                if (numeralId >= minValue && numeralId <= maxValue)
                {
                    if (i == 0)
                    {
                        thiefNumeralId = numeralId;
                    }

                    else if (numeralId > thiefNumeralId)
                    {
                        thiefNumeralId = numeralId;
                    }
                }
            }
            Console.WriteLine(thiefNumeralId);
        }
    }
}
