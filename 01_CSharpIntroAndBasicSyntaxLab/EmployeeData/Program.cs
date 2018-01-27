using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeId = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0:D8}", employeeId);
            Console.WriteLine("Salary: {0:F2}", salary);
        }
    }
}
