using System;
using System.Linq;
using System.Collections.Generic;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, decimal> priceDict = new Dictionary<string, decimal>();
            IDictionary<string, int> quantityDict = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                if (input[0].Equals("stocked"))
                {
                    break;
                }

                string product = input[0];
                decimal price = Decimal.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                
                if (!priceDict.ContainsKey(product))
                {
                    priceDict.Add(product, 0);
                    quantityDict.Add(product, 0);
                }

                priceDict[product] = price;
                quantityDict[product] += quantity;

            }

            //var tuple1 = Tuple.Create(priceDict, quantityDict);

            // print products, their quantities and prices (etc.)
            // here we use Zip method and Tuple class (construct) in order to wrap two dictionaries together
            // and use them in one foreach loop;
            // we tell one dictionary (priceDict) from the other (quantityDict) using Item1 and Item2 as per
            // Tuple construction;
            decimal grandTotal = 0;
            foreach (var product in priceDict.Zip(quantityDict, Tuple.Create))
            {
                decimal productPriceTotal = product.Item1.Value * product.Item2.Value;
                grandTotal += productPriceTotal;
                string productName = product.Item1.Key;
                decimal productPrice = product.Item1.Value;
                int productQuantity = product.Item2.Value;

                Console.WriteLine("{0}: ${1:F2} * {2} = ${3:F2}", productName, productPrice,
                        productQuantity, productPriceTotal);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Grand Total: ${0:F2}", grandTotal);
        }
    }
}
