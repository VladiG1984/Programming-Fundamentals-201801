using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt1 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int[] arrayInt2 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int arrayInt1Length = arrayInt1.Length;
            int arrayInt2Length = arrayInt2.Length;

            int[] arrayIntMaxLength;
            int[] arrayIntMinLength;
            int lengthMinArray;
            int lengthMaxArray;

            //Determine which is the longer and which the shorter array before adding the two together
            if (arrayInt1Length >= arrayInt2Length)
            {
                arrayIntMaxLength = arrayInt1.Clone() as int[];
                arrayIntMinLength = arrayInt2.Clone() as int[];
                lengthMinArray = arrayInt2Length;
                lengthMaxArray = arrayInt1Length;
            }
            else
            {
                arrayIntMaxLength = arrayInt2.Clone() as int[];
                arrayIntMinLength = arrayInt1.Clone() as int[];
                lengthMinArray = arrayInt1Length;
                lengthMaxArray = arrayInt2Length;
            }

            //Create new array with max length out of the array with shorter length (if such exists)
            int[] arrayIntRevised = new int[lengthMaxArray];

            //Assign already existing values from shorter array
            for (int element = 0; element < lengthMinArray; element++)
            {
                arrayIntRevised[element] = arrayIntMinLength[element];
            }

            //Assign new, non-existent values from shorter array
            for (int element = lengthMinArray; element < lengthMaxArray; element++)
            {
                arrayIntRevised[element] = arrayIntRevised[element - lengthMinArray];
            }

            //Sum the two arrays with equal length and save sums in a third array
            int[] arrayIntSum = new int[lengthMaxArray];

            for (int element = 0; element < lengthMaxArray; element++)
            {
                arrayIntSum[element] = arrayIntMaxLength[element] + arrayIntRevised[element];
            }

            foreach (int element in arrayIntSum)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
            // Note: There is an easier solution to this problem using no if statements, but rather assigning
            // sums to the resultant (sums) array using values from the other two arrays on the basis of
            // [position % array's length].
        }
    }
}
