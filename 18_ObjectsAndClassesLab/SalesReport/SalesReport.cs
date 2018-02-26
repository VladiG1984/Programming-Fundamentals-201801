using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int salesNumber = int.Parse(Console.ReadLine());
            IDictionary<string, double> townSalesDict = new SortedDictionary<string, double>();

            for (int i = 0; i < salesNumber; i++)
            {
                Sale sale = Sale.Read();
                string town = sale.Town;
                double price = sale.Price;
                double quantity = sale.Quantity;
                double totalSales = price * quantity;

                if (!townSalesDict.ContainsKey(town))
                {
                    townSalesDict.Add(town, 0);
                }
                townSalesDict[town] += totalSales;
            }

            foreach (KeyValuePair<string, double> townSales in townSalesDict)
            {
                Console.WriteLine("{0} -> {1:F2}", townSales.Key, townSales.Value);
            }
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public static Sale Read()
        {
            string[] saleInput = Console.ReadLine().Split(' ').ToArray();
            string town = saleInput[0];
            string product = saleInput[1];
            double price = double.Parse(saleInput[2]);
            double quantity = double.Parse(saleInput[3]);
            Sale sale = new Sale(town, product, price, quantity);

            return sale;
        }

        public Sale(string town, string product, double price, double quantity)
        {
            Town = town;
            Product = product;
            Price = price;
            Quantity = quantity;
        }
    }
}
