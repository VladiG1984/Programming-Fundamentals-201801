using System;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberInputRows = sbyte.Parse(Console.ReadLine());

            string bracketsString = "";
            bool isBalanced = true;

            for (int inputRow = 1; inputRow <= numberInputRows; inputRow++)
            {
                string rowText = Console.ReadLine();

                if (rowText.Length == 1 && rowText == "(" || rowText == ")")
                {
                    bracketsString += rowText;
                }
            }

            for (int rowCheck = 0; rowCheck < bracketsString.Length; rowCheck++)
            {
                if (rowCheck % 2 == 0 && bracketsString[rowCheck] != '(')
                {
                    isBalanced = false;
                    break;
                }
                if (rowCheck % 2 != 0 && bracketsString[rowCheck] != ')')
                {
                    isBalanced = false;
                    break;
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
        }
    }
}
