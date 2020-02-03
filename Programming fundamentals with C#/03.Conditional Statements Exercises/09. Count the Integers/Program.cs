using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (true)
            {
                try
                {
                    var validNumber = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch
                {
                    Console.WriteLine($"{counter}");
                    return;
                }
            }
          
        }
    }
}
