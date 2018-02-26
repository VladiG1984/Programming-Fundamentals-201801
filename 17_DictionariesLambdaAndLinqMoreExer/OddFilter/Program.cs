using System;
using System.Linq;
using System.Collections.Generic;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Include in list only even numbers entered in the console
            List<int> numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .Where(x => x % 2 == 0)
                        .ToList();

            // Calculate average of even numbers (remaing after exclusion of odd numbers)
            double numbersAv = numbers.Average();
            // Change the numbers on the basis of whether they are larger or small than the average
            // (Linq code below works but I would feel more comfortable using the for loop instead.)
            // numbers = numbers.Select(x => x = x > numbersAv ? ++x : --x).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > numbersAv)
                {
                    numbers[i]++;
                }
                else
                {
                    numbers[i]--;
                }
            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
