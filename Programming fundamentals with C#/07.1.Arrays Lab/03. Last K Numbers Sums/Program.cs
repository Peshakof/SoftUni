using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            int previousElements = int.Parse(Console.ReadLine());

            long[] sequence = new long[numberOfElements];
            sequence[0] = 1;

            for (int i = 1; i < numberOfElements; i++)
            {
                long sum = 0;
                int counter = 0;

                for (int j = i ; j >= 0; j--)
                {
                    sum += sequence[j];
                    counter++;

                    if (counter > previousElements)
                    {
                        break;
                    }
                }
                sequence[i] = sum;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}