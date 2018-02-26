using System;
using System.Linq;
using System.Collections.Generic;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();
            char[] charList = Console.ReadLine().ToArray();
                        
            foreach (char element in charList)
            {
                if (element >= '0' && element <= '9')
                {
                    numbersList.Add(int.Parse(element.ToString()));
                }
                else
                {
                    nonNumbersList.Add(element);
                }
            }

            int[] takeList = numbersList.Where((x, i) => i % 2 == 0).ToArray();
            int[] skipList = numbersList.Where((x, i) => i % 2 == 1).ToArray();

            List<char> result = new List<char>();
            int totalSymbols = 0;

            for (int i = 0; i < takeList.Length; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];
                
                List<char> intermedResult = nonNumbersList.Skip(totalSymbols).Take(take).ToList();
                result = result.Concat(intermedResult).ToList();
                totalSymbols += take + skip;
            }

            Console.WriteLine(String.Join(null, result));
        }
    }
}
