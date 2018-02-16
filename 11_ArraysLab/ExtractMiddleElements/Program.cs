using System;
using System.Linq;

namespace ExtractMiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int arrayLength = arrayInt.Length;
            string result = "";

            if( arrayLength % 2 == 0)
            {
                Console.Write("{ ");
                for (int pointer = (arrayLength / 2) - 1; pointer <= arrayLength / 2; pointer++)
                {
                    result += arrayInt[pointer] + ", ";
                }
                
                Console.Write(result.Remove(result.Length - 2, 2));
                Console.WriteLine(" }");
            }

            else if (arrayLength % 2 != 0 && arrayLength != 1)
            {
                Console.Write("{ ");
                for (int pointer = (arrayLength / 2) - 1; pointer <= (arrayLength / 2) + 1; pointer++)
                {
                    result += arrayInt[pointer] + ", ";
                }

                Console.Write(result.Remove(result.Length - 2, 2));
                Console.WriteLine(" }");
            }
            else
            {
                result = arrayInt[0].ToString();
                Console.WriteLine("{ " + result + " }");
            }

        }
    }
}
