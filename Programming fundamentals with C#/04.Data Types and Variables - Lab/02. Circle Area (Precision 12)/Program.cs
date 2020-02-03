using System;

namespace _02._Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * r * r;

            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
