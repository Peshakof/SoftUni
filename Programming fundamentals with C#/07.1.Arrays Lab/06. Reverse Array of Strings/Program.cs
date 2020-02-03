using System;
using System.Linq;


namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine()
                             .Split(' ')
                             .ToArray();

            string[] reversedText = texts.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reversedText));
        }
    }
}
