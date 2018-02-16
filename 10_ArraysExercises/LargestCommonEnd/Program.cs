using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Trim().Split(' ').ToArray();
            string[] array2 = Console.ReadLine().Trim().Split(' ').ToArray();

            int MaxCount = 0;
            
            // Check for matching subsequences in the arrays from left to right
            for(int colArray1 = 0; colArray1 < array1.Length; colArray1++)
            {
                for (int colArray2 = 0; colArray2 < array2.Length; colArray2++)
                {
                    if ((array1[colArray1] == array2[colArray2]) && ((colArray1 == 0 && colArray2 == 0) ||
                        (colArray1 == array1.Length - 1 && colArray2 == array2.Length - 1)))
                    {
                        int count = 1;
                        int colArray1Inner = colArray1;
                        int colArray2Inner = colArray2;

                        while (++colArray1Inner < array1.Length && ++colArray2Inner < array2.Length)
                        {
                            if (array1[colArray1Inner] == array2[colArray2Inner])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        
                        if(count > MaxCount)
                        {
                            MaxCount = count;
                        }
                    }
                }
            }

            // Check for matching subsequences in the arrays from right to left
            // Reverse the two original arrays
            string[] array1Reversed = array1.Reverse().ToArray();
            string[] array2Reversed = array2.Reverse().ToArray();

            for (int colArray1 = 0; colArray1 < array1Reversed.Length; colArray1++)
            {
                for (int colArray2 = 0; colArray2 < array2Reversed.Length; colArray2++)
                {
                    // If we modify the if statement below, we could use the code for matching substrings located
                    // not only at the ends of the arrays but also somewhere inside the array.
                    // There is an easier solution to this one if we only want to match substrings at the ends of
                    // the two arrays, as suggested by the hints in SoftUni's homework file.
                    if ((array1Reversed[colArray1] == array2Reversed[colArray2]) && 
                        ((colArray1 == 0 && colArray2 == 0) || (colArray1 == array1Reversed.Length - 1 && 
                        colArray2 == array2Reversed.Length - 1)))
                    {
                        int count = 1;
                        int colArray1Inner = colArray1;
                        int colArray2Inner = colArray2;

                        while (++colArray1Inner < array1Reversed.Length && ++colArray2Inner < array2Reversed.Length)
                        {
                            if (array1Reversed[colArray1Inner] == array2Reversed[colArray2Inner])
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (count > MaxCount)
                        {
                            MaxCount = count;
                        }
                    }
                }
            }
            Console.WriteLine(MaxCount);
        }
    }
}
