using System;

namespace Problem_10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                return;
            }
            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {multiplier} = {number*multiplier}");
                multiplier += 1;
                
                
            }
        }
    }
}
