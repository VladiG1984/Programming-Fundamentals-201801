using System;
using System.Linq;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            bool canJump = true;
            int count = 0;
            int sumValues = 0;

            while (canJump)
            {
                sumValues += arrayInt[count];
                bool canMoveRight = count + arrayInt[count] >= 0 && count + arrayInt[count] < arrayInt.Length;
                bool canMoveLeft = count - arrayInt[count] >= 0 && count - arrayInt[count] < arrayInt.Length;

                if (canMoveRight)
                {
                    count += arrayInt[count];
                }
                else if (canMoveLeft)
                {
                    count = count - arrayInt[count];
                }
                else
                {
                    canJump = false;
                    Console.WriteLine(sumValues);
                }
            }
        }
    }
}
