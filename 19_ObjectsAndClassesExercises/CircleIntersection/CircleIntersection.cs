using System;
using System.Linq;
using System.Collections.Generic;

namespace CircleIntersection
{
    class CircleIntersection
    {
        static void Main(string[] args)
        {
            // Read console for input for two circles to be compared
            double[] circle1Raw = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] circle2Raw = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            // Define circles 1 and 2
            Circle circle1 = CreateCircle(circle1Raw);
            Circle circle2 = CreateCircle(circle2Raw);

            // Check if the two circles intersect and print result
            if (Circle.Intersect(circle1, circle2) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        // Creates a circle using class Point and class Circle defined below
        public static Circle CreateCircle(double[] circleRaw)
        {
            double x = circleRaw[0];
            double y = circleRaw[1];
            double radius = circleRaw[2];

            Point center= new Point(x, y);

            Circle circle = new Circle(center, radius);

            return circle;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructs how to input and read the points parameters (properties)
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Line
    {
        // Defines line's properties
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public double Length
        {
            get
            {
                return CalcLength(FirstPoint, SecondPoint);
            }
        }

        // Calculates the length of a line (i.e., the distance between two points)
        public static double CalcLength(Point firstPoint, Point secondPoint)
        {
            double x1 = firstPoint.X;
            double x2 = secondPoint.X;
            double y1 = firstPoint.Y;
            double y2 = secondPoint.Y;

            double length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            
            return length;
        }

        // Constructs how to read and write the line's parameters/ properties
        public Line(Point firstPoint, Point secondPoint)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
        }
    }

    class Circle
    {
        // Defines the circle's properties
        public Point Point { get; set; }
        public double Radius { get; set; }

        // Checks if two circles intersect each other based on the distance between their centers relative
        // to the sum of their radiuses
        public static bool Intersect(Circle c1, Circle c2)
        {
            Point firstPoint = c1.Point;
            Point secondPoint = c2.Point;
            double radiusC1 = c1.Radius;
            double radiusC2 = c2.Radius;

            Line lineBetweenCircleCenters = new Line(firstPoint, secondPoint);
            double distanceBetweenCircleCenters = lineBetweenCircleCenters.Length;

            if (distanceBetweenCircleCenters > radiusC1 + radiusC2)
            {
                return false;
            }
            return true;
        }

        // Constructs how to read and write the circle's properties/ parameters
        public Circle(Point point, double radius)
        {
            Point = point;
            Radius = radius;
        }
    }
}
