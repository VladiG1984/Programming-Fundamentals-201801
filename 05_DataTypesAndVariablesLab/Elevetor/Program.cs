using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((1.0 * numberOfPeople) / capacityElevator);
            Console.WriteLine(courses);
        }
    }
}
