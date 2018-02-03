using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object object1 = word1 + " " + word2;
            string word3 = (string)object1;

            Console.WriteLine(word3);
        }
    }
}
