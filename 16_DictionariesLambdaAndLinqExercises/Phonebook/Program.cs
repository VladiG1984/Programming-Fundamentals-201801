using System;
using System.Linq;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                if (command[0].Equals("A"))
                {
                    if (!phonebook.ContainsKey(command[1]))
                    {
                        phonebook.Add(command[1],command[2]);
                    }
                    else
                    {
                        phonebook[command[1]] = command[2];
                    }
                }
                else if (command[0].Equals("S"))
                {
                    if (phonebook.ContainsKey(command[1]))
                    {
                        Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", command[1]);
                    }
                }
                else if (command[0].Equals("END"))
                {
                    break;
                }
            }
        }
    }
}
