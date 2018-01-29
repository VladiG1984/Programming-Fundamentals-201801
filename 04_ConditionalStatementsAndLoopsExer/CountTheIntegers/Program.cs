using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                //int counter = 0;

                while (true)
                {
                    int integer = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
