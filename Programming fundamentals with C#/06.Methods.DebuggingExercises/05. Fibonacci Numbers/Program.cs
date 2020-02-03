using System;

namespace _05._Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = CalculateFibonacci(number);
            Console.WriteLine(result);

        }
        static int CalculateFibonacci(int number)
        {
            int result = 0;

            if (number == 0 || number == 1)
            {
                result = 1;
                return result;
            }
            int previousNumber = 1;
            int beforePrevious = 1;

            for (int i = 2; i <= number; i++)
            {
                result = previousNumber + beforePrevious;
                beforePrevious = previousNumber;
                previousNumber = result;
            }

            return result;
        }
    }
}
