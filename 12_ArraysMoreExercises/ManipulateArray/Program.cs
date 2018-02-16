using System;
using System.Linq;

namespace ManipulateArray
{
    class Program
    {
        static string[] MakeDistinct(string[] array)
        {
            string[] arrayStringDistinct = array.Distinct().ToArray();
            array = arrayStringDistinct;
            return array;
        }

        static void Main(string[] args)
        {
            string[] arrayString = Console.ReadLine().Trim().Split(' ').ToArray();
            int numberLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberLines; i++)
            {
                string[] arrayCommands = Console.ReadLine().Trim().Split(' ').ToArray();

                if (arrayCommands[0] == "Distinct")
                {
                    arrayString = MakeDistinct(arrayString);
                }

                if (arrayCommands[0] == "Reverse")
                {
                    Array.Reverse(arrayString);
                }

                if (arrayCommands[0] == "Replace")
                {
                    int pointer = int.Parse(arrayCommands[1]);

                    arrayString[pointer] = arrayCommands[2];
                }
            }

            for (int i = 0; i < arrayString.Length; i++)
            {
                if (i == arrayString.Length - 1)
                {
                    Console.Write("{0}", arrayString[i]);
                }
                else
                {
                    Console.Write("{0}, ", arrayString[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
