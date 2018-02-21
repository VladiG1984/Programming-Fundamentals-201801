using System;
using System.Linq;
using System.Collections.Generic;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, SortedDictionary<string, int>> logDictionary = 
                        new SortedDictionary<string, SortedDictionary<string, int>>();

            int numberOfLogEntries = int.Parse(Console.ReadLine());

            for (int entry = 0; entry < numberOfLogEntries; entry++)
            {
                string[] log = Console.ReadLine()
                        .Split(' ')
                        .ToArray();

                //Console.WriteLine(String.Join(", ", log));

                string name = log[1];
                string addressIP = log[0];
                int duration = int.Parse(log[2]);

                if (!logDictionary.ContainsKey(name))
                {
                    logDictionary.Add(name, new SortedDictionary<string, int>());
                }

                if (!logDictionary[name].ContainsKey(addressIP))
                {
                    logDictionary[name].Add(addressIP, duration);
                }
                else
                {
                    logDictionary[name][addressIP] += duration;
                }
            }

            foreach (KeyValuePair<string, SortedDictionary<string, int>> log in logDictionary)
            {
                string name = log.Key;
                int durationSum = log.Value.Values.Sum();
                string[] addressIPs = log.Value.Keys.ToArray();

                Console.WriteLine("{0}: {1} [{2}]", name, durationSum, String.Join(", ", addressIPs));
                //Console.WriteLine("{0}: {1} [{2}]", log.Key, log.Value.Values.Sum(), String.Join(", ", log.Value.Keys));
            }
        }
    }
}
