using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToArray();

            int[] result;

            int arrLength = nums.Length;

            if (arrLength == 1)
            {
                result = new int[1];
                result[0] = nums[0];
            }
            else if (arrLength %2 == 0)
            {
                result = new int[2];
                result[0] = nums[arrLength / 2 - 1];
                result[1] = nums[arrLength / 2];
            }
            else
            {
                result = new int[3];
                result[0] = nums[arrLength / 2 - 1];
                result[1] = nums[arrLength / 2];
                result[2] = nums[arrLength / 2 + 1];

            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
