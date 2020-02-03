using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }
        static string ReversedNumber(string number)
        {
            string reversedNumber = "";

            for (int i = number.Length -1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }

            return reversedNumber;
        }
    }
}
