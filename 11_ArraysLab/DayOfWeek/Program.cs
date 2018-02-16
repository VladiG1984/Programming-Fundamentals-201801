using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday",
                "Sunday"};

            int dayOfWeek = int.Parse(Console.ReadLine());
            
            if (dayOfWeek < 1 || dayOfWeek > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[dayOfWeek - 1]);
            }
        }
    }
}
