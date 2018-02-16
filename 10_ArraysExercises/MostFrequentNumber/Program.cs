using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {      

        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            // Create variables to hold the maximum number of occurrences of a number within the origianl array
            // and this number's value.
            int maxCounter = 0;
            int mostFreqNumber = 0;

            // Starting with the first element of the original array, try to find subsequent matching elements
            for (int pointer = 0; pointer < arrayInt.Length - 1; pointer++)
            {
                // Create counter to keep count of the current number of matched pairs of elements and
                // create a number to keep the value of the current element being matched
                int counter = 0;
                int number = arrayInt[pointer];

                // Here we match each element of the original array with all subsequent ones. If there are matches,
                // we track that with counter.
                for (int count = pointer + 1; count < arrayInt.Length; count++)
                {
                    if (number == arrayInt[count])
                    {
                        counter++;
                    }
                }

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    mostFreqNumber = number;
                }

            }

            // Create and print the most frequent number. Else print nothing.
            if (maxCounter > 0)
            {
                Console.WriteLine(mostFreqNumber);
            }
        }
    }
}
