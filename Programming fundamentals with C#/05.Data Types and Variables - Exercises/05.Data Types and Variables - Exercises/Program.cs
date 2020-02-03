using System;

namespace _05.Data_Types_and_Variables___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //-100
            // 128
            //-3540
            // 64876
            // 2147483648
            //-1141583228
            //-1223372036854775808

            sbyte number1 = sbyte.Parse(Console.ReadLine());
            byte number2 = byte.Parse(Console.ReadLine());
            short number3 = short.Parse(Console.ReadLine());
            ushort number4 = ushort.Parse(Console.ReadLine());
            uint number5 = uint.Parse(Console.ReadLine());
            long number6 = long.Parse(Console.ReadLine());
            long number7 = long.Parse(Console.ReadLine());

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
        }
    }
}
