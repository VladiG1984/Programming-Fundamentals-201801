using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char value = char.Parse(Console.ReadLine());

            int valueInt = (int)Char.GetNumericValue(value);

            string valueType = "other";

            if (valueInt >= 0 && valueInt <= 9)
            {
                valueType = "digit";
            }
            else
            {
                switch (value)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        valueType = "vowel";
                        break;
                }
            }
            Console.WriteLine(valueType);
        }
    }
}
