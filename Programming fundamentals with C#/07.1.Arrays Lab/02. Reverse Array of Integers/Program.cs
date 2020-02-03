using System;
using System.Linq;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)

        {
            int numberOfIntegers = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfIntegers];

            for (int i = 0; i < numberOfIntegers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            int[] reversed = numbers.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
