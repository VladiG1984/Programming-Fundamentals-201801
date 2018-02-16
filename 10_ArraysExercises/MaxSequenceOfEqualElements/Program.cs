using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            foreach (int member in array)
            {
                Console.Write("{0} ", member);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            // Create variables to hold the maximum count of matching pairs and the value within each one of
            // the matched elements. This is to be used for creating an array holding the longest sequence of
            // equal elements.
            int maxCounter = 0;
            int maxCounterNumber = 0;

            // Starting with the first element of the original array, try to find subsequent matching elements
            for (int pointer = 0; pointer < arrayInt.Length - 1; pointer++)
            {
                // Create counter to keep count of the current number of matched pairs of elements and
                // create a counterNumber to keep the value of the current element being matched
                int counter = 0;
                int counterNumber = arrayInt[pointer];

                // Here we match each element of the original array with all subsequent ones. If there are matches,
                // we track that with counter. With each incremental match we change the value of the pointer, 
                // which indicates the position of the element being matched within the original array. This is
                // to prevent unnecessary looping through already pairs matched.
                for (int count = pointer + 1; count < arrayInt.Length; count++)
                {
                    if (counterNumber != arrayInt[count])
                    {
                        break;
                    }
                    counter++;
                    pointer++;
                }

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    maxCounterNumber = counterNumber;
                }

            }

            // Create and print the outcome array if there are any matched pairs. Else print nothing.
            if (maxCounter > 0)
            {
                int[] arrayMaxSeq = new int[maxCounter + 1];
                for (int pointer = 0; pointer < maxCounter + 1; pointer++)
                {
                    arrayMaxSeq[pointer] = maxCounterNumber;
                }

                PrintArray(arrayMaxSeq);
            }
        }
    }
}
