using System;
using System.Linq;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            // input point coordinates
            double[] point1Raw = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] point2Raw = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            // define the two points
            Point point1 = new Point() { X = point1Raw[0], Y = point1Raw[1] };
            Point point2 = new Point() { X = point2Raw[0], Y = point2Raw[1] };

            // define the line and then calculate its length based on a property LengthProp of class Line
            Line line = new Line(point1, point2);
            double lineLength = line.LengthProp;

            // calculate the length of a line using the method LengthMethod of class Line
            double lineLength1 = Line.LengthMethod(point1, point2);

            //Console.WriteLine("point1 (X,Y): {0}, {1}", point1.X, point1.Y);
            //Console.WriteLine("point2 (X,Y): {0}, {1}", point2.X, point2.Y);
            Console.WriteLine("distance: {0:F3}", lineLength);
            Console.WriteLine("distance: {0:F3}", lineLength1);
        }

    }

    class Point
    {
        // define class Point property variables (properties)
        public double X { get; set; }
        public double Y { get; set; }

        // define constructor
        //public Point(double x, double y)
        //{
        //    X = x;
        //    Y = y;
        //}

    }

    class Line
    {
        // properties: used to define input parameters
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public double LengthProp
        {
            get
            {
                return LengthMethod(P1,P2);
            }
        }

        // methods: functions to be called using {className.methodName(properties)
        // properties' positions within the method can be defined with the help of a constructor structure within
        // the class
        public static double LengthMethod(Point P1, Point P2)
        {
            double x1 = P1.X;
            double x2 = P2.X;
            double y1 = P1.Y;
            double y2 = P2.Y;

            double length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            return length;
        }

        //define constructor
        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }
}
