using System;

namespace problem03EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            var salary = int.Parse(Console.ReadLine());

            Console.WriteLine($"{name}");
            Console.WriteLine($"{age}");
            Console.WriteLine($"{employeeID:D8}");
            Console.WriteLine($"{salary:F2}");
        }
    }
}
