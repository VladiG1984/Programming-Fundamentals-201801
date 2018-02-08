using System;

namespace LongerLine
{
    class Program
    {
        static double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt((Math.Abs(x1 - x2) * Math.Abs(x1 - x2)) +
                    (Math.Abs(y1 - y2) * Math.Abs(y1 - y2)));
            return lineLength;
        }

        static double GetDistanceToCenter(double x, double y)
        {
            double distanceToCenter = Math.Sqrt(x * x + y * y);
            //Console.WriteLine(distanceToCenter);
            return distanceToCenter;
        }

        static void Main(string[] args)
        {
            double lineLength = 0;
            double finalX1 = 0;
            double finalY1 = 0;
            double finalX2 = 0;
            double finalY2 = 0;

            for (int line = 0; line < 2; line++)
            {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                if(lineLength <= GetLineLength(x1, y1, x2, y2))
                {
                    lineLength = GetLineLength(x1, y1, x2, y2);
                    finalX1 = x1;
                    finalY1 = y1;
                    finalX2 = x2;
                    finalY2 = y2;
                }
            }

            double distanceToCenterPnt1 = GetDistanceToCenter(finalX1, finalY1);
            double distanceToCenterPnt2 = GetDistanceToCenter(finalX2, finalY2);

            if (distanceToCenterPnt1 <= distanceToCenterPnt2)
            {
                Console.WriteLine($"({finalX1}, {finalY1})({finalX2}, {finalY2})");
            }
            else
            {
                Console.WriteLine($"({finalX2}, {finalY2})({finalX1}, {finalY1})");
            }
        }
    }
}
