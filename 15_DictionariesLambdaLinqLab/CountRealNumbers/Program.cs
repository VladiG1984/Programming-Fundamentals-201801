using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] realNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            IDictionary<double, int> realNumsDict = new SortedDictionary<double, int>();

            foreach(double realNum in realNums)
            {
                if(realNumsDict.ContainsKey(realNum))
                {
                    realNumsDict[realNum]++;
                }
                else
                {
                    realNumsDict[realNum] = 1;
                }
            }

            foreach (KeyValuePair<double, int> realNum in realNumsDict)
            {
                Console.WriteLine("{0} -> {1}", realNum.Key, realNum.Value);
            }
        }
    }
}
