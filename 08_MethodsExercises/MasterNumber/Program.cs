using System;

namespace MasterNumber
{
    class Program
    {
        static bool CheckNumberSymmetry(int number)
        {
            bool isSymmetric = true;

            string numberString = number.ToString();
            byte numberLength = (byte)numberString.Length;
            //byte numberHalfLength = (byte)Math.Ceiling((double)numberString.Length / 2);
            byte numberHalfLength = (byte)(numberString.Length / 2);
            //string reversedHalfString = "";

            for (int i = 0; i <= numberHalfLength - 1; i++)
            {
                //Console.WriteLine("i = " + numberString[i]);
                //Console.WriteLine("j = " + numberString[numberLength - (1 + i)]);
                if (numberString[i] != numberString[numberLength - (1 + i)])
                {
                    isSymmetric = false;
                    break;
                }
            }
            //Console.WriteLine(isSymmetric);
            return isSymmetric;
        }

        static bool CheckSumofDigitsDivisionBy7(int number)
        {
            bool isSumOfDigitsDivBy7 = false;
            int sumDigits = 0;
            
            while (number != 0)
            {
                int remainder = (int)Math.Abs(number % 10);
                sumDigits += remainder;
                number = number / 10;
            }

            if (sumDigits % 7 == 0)
            {
                isSumOfDigitsDivBy7 = true;
            }
            //Console.WriteLine("isSumOfDigitsDivBy7: " + isSumOfDigitsDivBy7);
            return isSumOfDigitsDivBy7;
        }

        static bool CheckNumberHasEvenDigit(int number)
        {
            bool hasEvenDigit = false;

            while (number != 0)
            {
                int digit = (int)Math.Abs(number % 10);
                if(digit % 2 == 0)
                {
                    hasEvenDigit = true;
                    break;
                }
                number = number / 10;
            }
            //Console.WriteLine("hasEvenDigit: " + hasEvenDigit);
            return hasEvenDigit;
        }

        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());

            for (int number = 1; number <= numberRange; number++)
            {
                //Console.WriteLine(number);
                bool isSymmetric = CheckNumberSymmetry(number);
                bool isSumOfDigitsDivBy7 = CheckSumofDigitsDivisionBy7(number);
                bool hasEvenDigit = CheckNumberHasEvenDigit(number);

                if(isSymmetric && isSumOfDigitsDivBy7 && hasEvenDigit)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
