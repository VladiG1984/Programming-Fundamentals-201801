using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolVariable = bool.Parse(Console.ReadLine());

            string stringVariable = Convert.ToString(boolVariable);

            if (stringVariable == "True")
            {
                stringVariable = "Yes";
            }
            else
            {
                stringVariable = "No";
            }
            Console.WriteLine(stringVariable);
        }
    }
}
