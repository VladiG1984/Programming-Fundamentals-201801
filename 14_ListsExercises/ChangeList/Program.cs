using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while(true)
            {
                string command = Console.ReadLine();

                List<string> commands = command.Split(' ').ToList();
                
                if (commands[0] == "Delete")
                {
                    integers.RemoveAll(i => i == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    integers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                else if (commands[0] == "Odd")
                {
                    integers = integers.Where(integer => integer % 2 != 0).ToList();
                    Console.WriteLine(String.Join(" ", integers));
                    break;
                }
                else if (commands[0] == "Even")
                {
                    integers = integers.Where(integer => integer % 2 == 0).ToList();
                    Console.WriteLine(String.Join(" ", integers));
                    break;
                }
            }
        }
    }
}
