using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;

            for (int i = second; i >= first; i--)
            {
                for (int j = second; j >= first; j--)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magic)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magic}");

                        return;
                    }
                }
            }


            Console.WriteLine($"{counter} combinations - neither equals {magic} ");
        }
    }
}
