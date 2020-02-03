using System;
using System.Linq;
using System.Collections.Generic;
namespace _08.Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {         

                if (i >= 0)
                {
                    result.Add(i);
                }
            }
            result.Reverse();
            Console.WriteLine(numbers);
            
        }
    }
}
