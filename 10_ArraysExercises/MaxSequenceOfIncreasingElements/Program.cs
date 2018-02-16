using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
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

            // Create a variable to hold the maximum count of increasing pairs.
            // Create a variable to hold the starting position within the original array at which the
            // increasing sequence with maximum length starts.
            int lengthMaxSeq = 0;
            int startPositionMaxSeq = 0;

            // Starting with the first element of the original array, try to find subsequent increasing elements
            for (int pointer = 0; pointer < arrayInt.Length - 1; pointer++)
            {
                // Create counter to keep count of the current number of increasing pairs of elements and
                // create a variable to keep the starting position of the current sequence of increasing elements
                int counter = 0;
                int startPosition = pointer; // Remeber start position of increasing sequence

                // Here we test for the existence of increasing pairs in a sequential order. If there are such, 
                // we track their number with a counter.
                for (int count = pointer + 1; count < arrayInt.Length; count++)
                {
                    if (arrayInt[count - 1] >= arrayInt[count])
                    {
                        break;
                    }
                    counter++;
                }
                // We change the value of the pointer to the original array with the number of recorded sequentially
                // increasing pairs so that we prevent unnecessary looping through already registered pairs of
                // increasing number.
                pointer += counter;

                // If the new sequence of increasing elements is longer than the longest previously recorded 
                // sequence of such elements, we preserve the info about its starting position within original
                // array and its number of pairs (length).
                if (lengthMaxSeq < counter)
                {
                    lengthMaxSeq = counter;
                    startPositionMaxSeq = startPosition;
                }

            }

            // Create and print the outcome array if there is a sequence of increasing elements. Else print nothing.
            if (lengthMaxSeq > 0)
            {
                int[] arrayMaxSeq = new int[lengthMaxSeq + 1];
                for (int pointer = 0; pointer < lengthMaxSeq + 1; pointer++)
                {
                    arrayMaxSeq[pointer] = arrayInt[startPositionMaxSeq + pointer];
                }

                PrintArray(arrayMaxSeq);
            }
        }
    }
}
