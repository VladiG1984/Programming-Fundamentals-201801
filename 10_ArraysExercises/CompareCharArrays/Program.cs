using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void PrintArray(string[] array)
        {
            foreach (string member in array)
            {
                Console.Write(member);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string[] arrayString1 = Console.ReadLine().Trim().Split(' ').ToArray();
            string[] arrayString2 = Console.ReadLine().Trim().Split(' ').ToArray();

            int arrayMinLength = Math.Min(arrayString1.Length, arrayString2.Length);

            bool arraysHaveIdenticalLetters = true;

            for (int i = 0; i < arrayMinLength; i++)
            {
                if (arrayString1[i].CompareTo(arrayString2[i]) < 0)
                {
                    PrintArray(arrayString1);
                    PrintArray(arrayString2);
                    arraysHaveIdenticalLetters = false;
                    break;
                }
                else if (arrayString1[i].CompareTo(arrayString2[i]) > 0)
                {
                    PrintArray(arrayString2);
                    PrintArray(arrayString1);
                    arraysHaveIdenticalLetters = false;
                    break;
                }
            }

            if (arraysHaveIdenticalLetters == true)
            {
                if (arrayString1.Length == arrayMinLength)
                {
                    PrintArray(arrayString1);
                    PrintArray(arrayString2);
                }
                else
                {
                    PrintArray(arrayString2);
                    PrintArray(arrayString1);
                }
                
            }
        }
    }
}
