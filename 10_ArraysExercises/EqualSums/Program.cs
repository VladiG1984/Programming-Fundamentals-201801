using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            bool elementExists = false;

            for (int pointer = 0; pointer < arrayInt.Length; pointer++)
            {
                int sumLeft = 0;
                int sumRight = 0;

                // Sum elements on the right of the pointer
                for (int elementsLeft = 0; elementsLeft < pointer; elementsLeft++)
                {
                    sumLeft += arrayInt[elementsLeft];
                }

                // Sum elements on the left of the pointer
                for (int elementsRight = pointer + 1; elementsRight < arrayInt.Length; elementsRight++)
                {
                    sumRight += arrayInt[elementsRight];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(pointer);
                    elementExists = true;
                    break;
                }
            }

            if (!elementExists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
