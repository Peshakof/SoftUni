using System;

namespace to_upperCase
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string output = input.ToUpper();

            Console.WriteLine($"{output}");
        }
    }
}
