using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "add")
                {
                    integers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    for (int i = command.Count - 1; i >= 2; i--)
                    {
                        integers.Insert(int.Parse(command[1]), int.Parse(command[i]));
                    }
                }
                else if (command[0] == "contains")
                {
                    Console.WriteLine(integers.IndexOf(int.Parse(command[1])));

                    // integers.FindIndex(x => x == int.Parse(command[1]));

                }
                else if (command[0] == "remove")
                {
                    integers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    int firstElementToShift = int.Parse(command[1]);

                    for (int i = 0; i < firstElementToShift; i++)
                    {
                        // move integers from beginning of list to the back until we reshuffle the 
                        // first n numbers of the original list
                        integers.Add(integers[0]);
                        integers.RemoveAt(0);
                    }                   
                }
                else if (command[0] == "sumPairs")
                {
                    for (int i = 0; i < integers.Count - 1; i++)
                    {
                        integers[i] = integers[i] + integers[i + 1];
                        integers.RemoveAt(i + 1);
                    }
                } else if (command[0] == "print")
                {
                    break;
                }
            }
            Console.WriteLine("[" + String.Join(", ", integers) + "]");
        }
    }
}
