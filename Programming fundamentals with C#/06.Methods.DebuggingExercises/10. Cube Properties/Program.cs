using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string request = Console.ReadLine();
            double result = 0.0;
            if (request == "face")
            {
                result = CalculateFace(side);
            }
            else if (request == "space")
            {
                result = CalculateSpace(side);
            }
            else if (request == "volume")
            {
                result = CalculateVolume(side);
            }
            else if (request == "area")
            {
                result = CalculateArea(side);
            }

            Console.WriteLine($"{result:F2}");
        }
        static double CalculateFace(double side)
        {
            double result = Math.Sqrt(2 * side * side);

            return result;
        }
        static double CalculateSpace(double side)
        {
            double result = Math.Sqrt(3 * side * side);

            return result;
        }
        static double CalculateVolume(double side)
        {
            double result = side * side * side;

            return result;
        }
        static double CalculateArea(double side)
        {
            double result = 6 * side * side;

            return result;
        }
    }
}
