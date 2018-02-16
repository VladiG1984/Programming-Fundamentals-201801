using System;
using System.Linq;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            bool containsMatch = false;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = i + 1; j < arrayInt.Length; j++)
                {
                    for (int k = 0; k < arrayInt.Length; k++)
                    {
                        if (arrayInt[i] + arrayInt[j] == arrayInt[k])
                        {
                            Console.WriteLine($"{arrayInt[i]} + {arrayInt[j]} == {arrayInt[k]}");
                            containsMatch = true;
                            break; // In my opinion, there should be no break, because we miss one combination
                            // (5 + 2 = 7) if we have the following sequence: 5 2 7 7 9:
                            // using "break;" will give: 5 + 2 = 7, 2 + 7 = 9, 2 + 7 = 9; whereas without "break;"
                            // we have one more 5 + 2 = 7, which I think should be the correct output
                        }
                    }

                }
            }

            if(!containsMatch)
            {
                Console.WriteLine("No");
            }
        }
    }
}
