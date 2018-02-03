using System;

namespace DifferentIntegerSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();

            try
            {

                long number = Convert.ToInt64(numberString);

                string result = $"{number} can fit in:";

                if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    result += $"\n* sbyte";
                }
                if (number >= byte.MinValue && number <= byte.MaxValue)
                {
                    result += $"\n* byte";
                }
                if (number >= short.MinValue && number <= short.MaxValue)
                {
                    result += $"\n* short";
                }
                if (number >= ushort.MinValue && number <= ushort.MaxValue)
                {
                    result += $"\n* ushort";
                }
                if (number >= int.MinValue && number <= int.MaxValue)
                {
                    result += $"\n* int";
                }
                if (number >= uint.MinValue && number <= uint.MaxValue)
                {
                    result += $"\n* uint";
                }
                if (number >= long.MinValue && number <= long.MaxValue)
                {
                    result += $"\n* long";
                }
               // if (number >= ulong.MinValue && number <= ulong.MaxValue)
               // {
               //    result += $"\n* ulong";
               // }

                Console.WriteLine(result);

            } catch (Exception)
            {
                //string numberStr = numberString;
                Console.WriteLine($"{numberString} can't fit in any type");
            }
            
        }
    }
}
