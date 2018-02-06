using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfKegs = sbyte.Parse(Console.ReadLine());

            decimal volumeOfBiggestKeg = 0M;
            string modelOfBiggestKeg = "";

            for (int keg = 1; keg <= numberOfKegs; keg++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                decimal volumeOfKeg = (decimal)Math.PI * radius * radius * height;

                if (volumeOfKeg > volumeOfBiggestKeg)
                {
                    volumeOfBiggestKeg = volumeOfKeg;
                    modelOfBiggestKeg = model;
                }
            }
            Console.WriteLine(modelOfBiggestKeg);
        }
    }
}
