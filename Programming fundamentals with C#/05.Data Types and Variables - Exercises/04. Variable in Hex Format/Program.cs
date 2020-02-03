using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            int number = Convert.ToInt32(inputNumber, 16);

            Console.WriteLine(number);
        }
    }
}
