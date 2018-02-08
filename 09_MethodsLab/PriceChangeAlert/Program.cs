using System;

namespace PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double limit = double.Parse(Console.ReadLine());
            double prevPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double priceDifference = PercentageChange(prevPrice, currentPrice);
                bool isSignificantDifference = CheckDifference(priceDifference, limit);
                string message = GetMessage(currentPrice, prevPrice, priceDifference, 
                        isSignificantDifference);
                Console.WriteLine(message);
                prevPrice = currentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double prevPrice, double priceDifference, 
                bool isSignificantDifference)
        {
            string message = "";
            if (priceDifference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", prevPrice, currentPrice,
                        priceDifference);
            }
            else if (isSignificantDifference && (priceDifference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", prevPrice, currentPrice,
                        priceDifference);
            }
            else if (isSignificantDifference && (priceDifference < 0))
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", prevPrice, currentPrice,
                        priceDifference);
            return message;
        }

        private static bool CheckDifference(double priceDifference, double limit)
        {
            bool isDiff = false;

            if (Math.Abs(priceDifference) >= 100 * limit)
            {
                isDiff = true;
                return isDiff;
            }
            return isDiff;
        }

        private static double PercentageChange(double previous, double current)
        {
            double percentageChange = 100 * ((current - previous) / previous);
            return percentageChange;
        }
    }
}
