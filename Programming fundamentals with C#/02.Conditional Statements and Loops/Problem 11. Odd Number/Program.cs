using System;

namespace Problem_11._Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                try
                {

                    var number = int.Parse(Console.ReadLine());
                    if (number % 2 == 1)
                    {
                        Console.WriteLine($"The number is: {number}");
                        break;
                    }
                }
                catch 
                {
                    Console.WriteLine("Please write an odd number.");
                }
            }
        }
    }
}
