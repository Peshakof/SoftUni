using System;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int counter = 0;

            for (int i = 1; i <= 20; i++)
            {
                command = Console.ReadLine();

             

                if (command == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    return;
                }
                else
                {
                    counter++;

                    Console.WriteLine($"Adding ingredient {command}.");
                }
                if (counter == 20)
                {
                    Console.WriteLine($"Preparing cake with 20 ingredients.");

                }



            }
        }    
    }
}
