using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            // create a list to hold the values of the max sequence
            List<int> maxSeqInt = new List<int>();
            int maxSeq = 0;

            // iterate through all elements of the original integer list to check for equal elements
            for (int position = 0; position < integers.Count; position++)
            {
                // start from current element for which we subsequently try to find an equal element in the
                // remaining elements of the sequence
                int integer = integers[position];
                int count = 1;

                // search for equal elements in the rest of the sequence (list)
                // whenever we find one, we increment the counter and we also increment the starting position of the 
                // matching algorithm so that whenever we come to the end of a matching subsequence of elements within
                // the list, we can start to look for another matching subsequence of elements right where the previous
                // subsequence ended;
                for (int posNext = position + 1; posNext < integers.Count; posNext++)
                {
                    if (integers[posNext] == integer)
                    {
                        count++;
                        position++;
                    }
                }

                // in the end of a group of equal elements, we check whether its length is longer than the previously
                // found longest such group; if so, we clear the list that holds the previous longest list of equal
                // elements and fill it with the elements comprising the current longest group;
                if(count > maxSeq)
                {
                    maxSeqInt.Clear();
                    maxSeq = count;

                    for (int iteration = 0; iteration < count; iteration++)
                    {
                        maxSeqInt.Add(integer);
                    }
                }
            }
            // prints the longest group of equal elements on the console
            Console.WriteLine(String.Join(" ", maxSeqInt));
        }
    }
}
