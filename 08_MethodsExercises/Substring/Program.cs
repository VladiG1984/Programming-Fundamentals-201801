using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                //Console.WriteLine(text[i] + ", " + Search);
                if (text[i] == Search)
                {
                    hasMatch = true;
                    //Console.WriteLine(hasMatch);

                    int endIndex = jump + 1;
                    //Console.WriteLine("endIndex: " + endIndex);
                    //Console.WriteLine("length: " + (text.Length - i));

                    if (endIndex > text.Length - i)
                    {
                        endIndex = text.Length - i;
                    }
                    //Console.WriteLine("endIndex after:" + endIndex);

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
