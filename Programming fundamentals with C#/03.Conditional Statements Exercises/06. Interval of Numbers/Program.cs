using System;

namespace _06._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int biggerNum = 0;
            int smallerNum = 0;

            if (firstNum > secondNum)
            {
                biggerNum = firstNum;
                smallerNum = secondNum;
            }
            else if (secondNum > firstNum)
            {
                biggerNum = secondNum;
                smallerNum = firstNum;
            }

            for (int i = smallerNum; i <= biggerNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
