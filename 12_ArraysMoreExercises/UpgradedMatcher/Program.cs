using System;
using System.Linq;

namespace UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productList = Console.ReadLine().Trim().Split(' ').ToArray();

            long[] quantityListRaw = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToArray();
            long[] quantityList = new long[productList.Length];
            quantityListRaw.CopyTo(quantityList, 0);

            decimal[] priceList = Console.ReadLine().Trim().Split(' ').Select(decimal.Parse).ToArray();
            //decimal[] priceList = new decimal[productList.Length];
            //priceListRaw.CopyTo(priceList, 0);

            string[] product = Console.ReadLine().Trim().Split(' ').ToArray();

            while (Array.Exists(product, element => element != "done"))
            {
                string productName = product[0];
                int indexOfProductInList = Array.IndexOf(productList, productName);
                long quantityProductOrdered = long.Parse(product[1]);
                decimal totalPriceProduct = priceList[indexOfProductInList] * quantityProductOrdered;

                if (quantityProductOrdered > quantityList[indexOfProductInList])
                {
                    Console.WriteLine("We do not have enough {0}", productName);
                }
                else {
                    Console.WriteLine("{0} x {1} costs {2:F2}", productName, quantityProductOrdered,
                        totalPriceProduct);

                    quantityList[indexOfProductInList] = quantityList[indexOfProductInList] - quantityProductOrdered;
                }

                product = Console.ReadLine().Trim().Split(' ').ToArray();
            }
        }
    }
}
