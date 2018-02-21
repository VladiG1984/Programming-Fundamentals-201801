using System;
using System.Linq;
using System.Collections.Generic;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().ToLower().Split(' ').ToArray();

            IDictionary<string, int> words = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if(words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words[word] = 1;
                }
            }

            List<string> wordsOddOccurr = new List<string>();
            int count = 0;

            foreach (KeyValuePair<string, int> item in words)
            {
                if(item.Value % 2 != 0)
                {
                    wordsOddOccurr.Add(item.Key);
                    count++;
                }
            }

            Console.WriteLine(String.Join(", ", wordsOddOccurr));
        }
    }
}
