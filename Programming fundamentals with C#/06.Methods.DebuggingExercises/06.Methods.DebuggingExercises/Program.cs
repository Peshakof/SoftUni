using System;

namespace _06.Methods.DebuggingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GreetingsByName(name);
        }
        static void GreetingsByName(string someName)
        {
            Console.WriteLine($"Hallo, {someName}!");
        }
    }
}
