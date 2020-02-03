using System;
using System.Linq;

namespace _04._Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool foundSum = true;

            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    sum = numbers[a] + numbers[b];

                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");

                        if (foundSum)
                        {
                            foundSum = false;
                        }
                    }
                  
                }
            }
            if (foundSum)
            {
                Console.WriteLine("No");
            }


        }
    }
}
