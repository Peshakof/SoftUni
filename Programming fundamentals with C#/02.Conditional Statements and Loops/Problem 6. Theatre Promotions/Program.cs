using System;

namespace Problem_6._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayType = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            if (dayType == "Weekday")
            {
                if (18 <= age && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else if (dayType == "Weekend")
            {
                if (18 <= age && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("15$");
                }
            }
            else if (dayType == "Holyday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (18 <= age && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
