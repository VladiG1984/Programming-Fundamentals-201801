using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void CompareTwoValues(long value1, long value2)
        {
            if (value1 >= value2)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine(value2);
            }
        }

        static void CompareTwoValues(char value1, char value2)
        {
            if (value1 >= value2)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine(value2);
            }
        }

        static void CompareTwoValues(string value1, string value2)
        {
            if (value1.CompareTo(value2) >= 0)
            {
                Console.WriteLine(value1);
            }
            else
            {
                Console.WriteLine(value2);
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            if (type == "int")
            {
                long value1 = long.Parse(Console.ReadLine());
                long value2 = long.Parse(Console.ReadLine());
                CompareTwoValues(value1, value2);
            }
            else if (type == "char")
            {
                char value1 = char.Parse(Console.ReadLine());
                char value2 = char.Parse(Console.ReadLine());
                CompareTwoValues(value1, value2);
            }
            else if (type == "string")
            {
                string value1 = Console.ReadLine();
                string value2 = Console.ReadLine();
                CompareTwoValues(value1, value2);
            }
        }
    }
}
