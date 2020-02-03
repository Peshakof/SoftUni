using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeole = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeole / elevatorCapacity);

            Console.WriteLine($"{courses}");
            if (courses == 1)
            {
                Console.WriteLine("All the persons fit inside the elevator.\n Only one course is needed.");
            }
        }
    }
}
