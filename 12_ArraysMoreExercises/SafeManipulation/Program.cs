using System;
using System.Linq;

namespace SafeManipulation
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

            bool isEnd = false;
            
            while (isEnd == false)
            {
                string[] arrayCommands = Console.ReadLine().Trim().Split(' ').ToArray();

                if (arrayCommands[0] == "Distinct")
                {
                    arrayString = MakeDistinct(arrayString);
                }
                else if (arrayCommands[0] == "Reverse")
                {
                    Array.Reverse(arrayString);
                }
                else if (arrayCommands[0] == "Replace" && int.Parse(arrayCommands[1]) >= 0 && 
                            int.Parse(arrayCommands[1]) < arrayCommands.Length)
                {
                    int pointer = int.Parse(arrayCommands[1]);
                    arrayString[pointer] = arrayCommands[2];
                }
                else if (arrayCommands[0] == "END")
                {
                    isEnd = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
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
