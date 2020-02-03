using System;
using System.Linq;
namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            int numberOfElements = numbers.Length;

            while (numberOfElements > 1)
            {
                for (int i = 0; i < numberOfElements - 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
                numberOfElements--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
