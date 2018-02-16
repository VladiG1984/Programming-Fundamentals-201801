using System;
using System.Linq;

namespace LargestCommonEndSolution2
{
    class Program
{
    static void Main(string[] args)
    {
            // This C# solution is taken directly from GitHub:
            // https://github.com/hammer4/SoftUni/blob/master/Programming%20Fundamentals/3.%20Arrays%20Exercises/01.%20Largest%20Common%20End/Largest%20Common%20End.cs
            string[] array1 = Console.ReadLine().Split(' ');
        string[] array2 = Console.ReadLine().Split(' ');
        int minLength = Math.Min(array1.Length, array2.Length);
        int diff = Math.Abs(array1.Length - array2.Length);
        int leftSeqLen = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (array1[i] != array2[i])
            {
                break;
            }

            leftSeqLen++;
        }

        array1 = array1.Reverse().ToArray();
        array2 = array2.Reverse().ToArray();
        int rightSeqLen = 0;
        for (int i = 0; i < minLength; i++)
        {
            if (array1[i] != array2[i])
            {
                break;
            }

            rightSeqLen++;
        }

        Console.WriteLine(Math.Max(leftSeqLen, rightSeqLen));
    }
}
}
