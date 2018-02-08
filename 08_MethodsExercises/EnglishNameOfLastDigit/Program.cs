using System;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void PrintEnglishNameOfLastDigit(long number)
        {
            long lastDigit = Math.Abs(number % 10);
            
            string englishName = "";

            switch(lastDigit)
            {
                case 0:
                    englishName = "zero";
                    //Console.WriteLine("zero");
                    break;
                case 1:
                    englishName = "one";
                    //Console.WriteLine("one");
                    break;
                case 2:
                    englishName = "two";
                    //Console.WriteLine("two");
                    break;
                case 3:
                    englishName = "three";
                    //Console.WriteLine("three");
                    break;
                case 4:
                    englishName = "four";
                    //Console.WriteLine("four");
                    break;
                case 5:
                    englishName = "five";
                    //Console.WriteLine("five");
                    break;
                case 6:
                    englishName = "six";
                    //Console.WriteLine("six");
                    break;
                case 7:
                    englishName = "seven";
                    //Console.WriteLine("seven");
                    break;
                case 8:
                    englishName = "eight";
                    //Console.WriteLine("eight");
                    break;
                case 9:
                    englishName = "nine";
                    //Console.WriteLine("nie");
                    break;
            }
            Console.WriteLine(englishName);
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            PrintEnglishNameOfLastDigit(number);
        }
    }
}
