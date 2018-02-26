using System;
using System.Linq;

namespace RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            // input from console for two rectangles as per problem description
            double[] rectangle1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] rectangle2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            // using class Rectangle and its constructor define two rectangles to compare
            Rectangle r1 = new Rectangle(rectangle1[0], rectangle1[1], rectangle1[2], rectangle1[3]);
            Rectangle r2 = new Rectangle(rectangle2[0], rectangle2[1], rectangle2[2], rectangle2[3]);

            // using class Rectangle and its method IsInside determine whether first rectangle is inside second
            if (Rectangle.IsInside(r1, r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }

    class Rectangle
    {
        // determine Rectangle properties
        public double TopSidePos { get; set; }
        public double LeftSidePos { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double BottomSidePos
        {
            get
            {
                return TopSidePos + Height;
            }
        }
        public double RightSidePos
        {
            get
            {
                return LeftSidePos + Width;
            }
        }
        
        // Define Rectangle's method
       public static bool IsInside(Rectangle r1, Rectangle r2)
        {
            if (r1.LeftSidePos >= r2.LeftSidePos && r1.RightSidePos <= r2.RightSidePos && 
                    r1.TopSidePos <= r2.TopSidePos && r1.BottomSidePos <= r2.BottomSidePos)
            {
                return true;
            }

            return false;
        }

        // Define Rectangle's constructor
        public Rectangle(double left, double top, double width, double height)
        {
            LeftSidePos = left;
            TopSidePos = top;
            Width = width;
            Height = height;
        }
    }
}
