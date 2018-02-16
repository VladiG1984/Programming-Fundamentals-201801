using System;
using System.Linq;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productList = Console.ReadLine().Trim().Split(' ').ToArray();
            long[] quantityList = Console.ReadLine().Trim().Split(' ').Select(long.Parse).ToArray();
            decimal[] priceList = Console.ReadLine().Trim().Split(' ').Select(decimal.Parse).ToArray();

            string product = Console.ReadLine();
            
            while (product != "done")
            {
                int indexOfProductInList = Array.IndexOf(productList, product);
                
                Console.WriteLine("{0} costs: {1}; Available quantity: {2}", product,
                    priceList[indexOfProductInList], quantityList[indexOfProductInList]);

                product = Console.ReadLine();
            }
        }
    }
}
