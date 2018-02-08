using System;
using System.Linq;

namespace SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().ToLower().Split(ArgumentsDelimiter);

            while (!command[0].Equals("stop"))
            {
                //string line = Console.ReadLine().Trim();
                int[] args = new int[2];

                if (command[0].Equals("add") ||
                    command[0].Equals("subtract") ||
                    command[0].Equals("multiply"))
                {
                    //string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);

                    //PerformAction(array, command[0], args);
                }

                PerformAction(array, command[0], args);

                PrintArray(array);
                Console.WriteLine('\n');

                command = Console.ReadLine().ToLower().Split(ArgumentsDelimiter);
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            //long[] array = arr.Clone() as long[];
            int pos = args[0] - 1;
            int value = args[1];
            
            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastValue = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastValue;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstValue = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstValue;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
