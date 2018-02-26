using System;
using System.Linq;

namespace ClosestTwoPoints
{
    class ClosedTwoPoints
    {
        static void Main(string[] args)
        {
            // enter number of points to compare
            int number = int.Parse(Console.ReadLine());
            Point[] points = new Point[number];

            // fill in array of points, which are to be compared
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                points[i] = new Point(int.Parse(input[0]), int.Parse(input[1]));

                // Side note: The code below can be used without the Point constructor
                // points[i] = new Point() { X = int.Parse(input[0]), Y = int.Parse(input[1]) };
            }

            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = new Point[2];

            // compare each one point with all of the others and calculate the minimal distance between them
            // keep the two closest points that are first to be encountered
            for (int i = 0; i < points.Length; i++)
            {
                Point point1 = points[i];

                for (int j = i + 1; j < points.Length; j++)
                {
                    Point point2 = points[j];

                    Line line = new Line(point1, point2);
                    double distance = line.LengthProp;

                    if (distance < minDistance)
                    {
                        closestTwoPoints = new Point[] { point1, point2 };
                        minDistance = distance;
                    }
                }
            }

            // print closest distance
            Console.WriteLine("{0:F3}", minDistance);

            // print two closest points that were the first to be determined
            foreach (Point point in closestTwoPoints)
            {
                Console.WriteLine("({0}, {1})", point.X, point.Y);
            }
        }
    }

    class Point
    {
        // define class Point property variables (properties)
        public double X { get; set; }
        public double Y { get; set; }

        //define constructor
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

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
                return LengthMethod(P1, P2);
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
