using System;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPrice = 0;

            for (int i = 0; i < 2; i++)
            {
                string price = Console.ReadLine();

                sbyte priceByte = 0;
                int priceInt = 0;

                if (sbyte.TryParse(price, out priceByte))
                {
                    priceByte = sbyte.Parse(price);
                    totalPrice += (int)4 * priceByte;
                }
                else
                {
                    priceInt = int.Parse(price);
                    totalPrice += (long)10 * priceInt;
                }
            }
            Console.WriteLine(totalPrice);
        }
    }
}
