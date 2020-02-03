using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(' ')
                .ToList();

            int result = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                string currentNumber = inputList[i];
                string reversed = "";

                for (int j = currentNumber.Length - 1; j >= 0 ; j--)
                {
                    reversed += currentNumber[j];
                }
                result += int.Parse(reversed);
            }
            Console.WriteLine(result);
        }
    }
}
