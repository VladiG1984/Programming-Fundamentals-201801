using System;
using System.Linq;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[]
            {
                ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' '
            };

            List<string> words = Console.ReadLine().Split(separators).ToList();

            words = words
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .ToList();

            List<string> wordsUpperCase = new List<string>();
            List<string> wordsLowerCase = new List<string>();
            List<string> wordsOther = new List<string>();

            foreach (string word in words)
            {
                int countUpper = 0;
                int countLower = 0;

                for (int character = 0; character < word.Length; character++)
                {
                    if (char.IsUpper(word[character]))
                    {
                        countUpper++;
                    }
                    else if (char.IsLower(word[character]))
                    {
                        countLower++;
                    }
                }

                if (countUpper == word.Length)
                {
                    wordsUpperCase.Add(word);
                }
                else if (countLower == word.Length)
                {
                    wordsLowerCase.Add(word);
                }
                else
                {
                    wordsOther.Add(word);
                }
            }

            Console.WriteLine("Lower-case: " + String.Join(", ", wordsLowerCase));
            Console.WriteLine("Mixed-case: " + String.Join(", ", wordsOther));
            Console.WriteLine("Upper-case: " + String.Join(", ", wordsUpperCase));
        }
    }
}
