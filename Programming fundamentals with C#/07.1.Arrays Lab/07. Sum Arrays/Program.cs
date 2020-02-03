using System;
using System.Linq;
namespace _07._Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                              .Split(' ')
                              .Select(int.Parse)
                              .ToArray();

            int[] secondArr = Console.ReadLine()
                              .Split(' ')
                              .Select(int.Parse)
                              .ToArray();

            int arr1Length = firstArr.Length;
            int arr2Length = secondArr.Length;
            int arrMax = Math.Max(arr1Length, arr2Length);

            int[] sum = new int[arrMax];

            for (int i = 0; i < arrMax; i++)
            {
                sum[i] = firstArr[i % arr1Length] + secondArr[i % arr2Length]; 
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
