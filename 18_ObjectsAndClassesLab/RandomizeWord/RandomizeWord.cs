using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace RandomizeWord
{
    class RandomizeWord
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int tempPos = rnd.Next(words.Length);
                string tempWord = words[i];

                words[i] = words[tempPos];
                words[tempPos] = tempWord;

            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
