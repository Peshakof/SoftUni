using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            string ingredient = "";
            int counter = 0;
            string output = "";

            int totalCalories = 0;

            for (int i = 1; i <= 20; i++)
            {

                ingredient = Console.ReadLine();
                output = ingredient.ToUpper()   ;
                if (output == "CHEESE")
                {
                    totalCalories += 500;
                    counter++;
                }
                else if (output == "TOMATO SAUCE")
                {
                    totalCalories += 150;
                    counter++;
                }
                else if (output == "SALAMI")
                {
                    totalCalories += 600;
                    counter++;
                }
                else if (output == "PEPPER")
                {
                    totalCalories += 50;
                    counter++;
                }
                else
                {
                    counter++;
                }
                if (counter == numberOfIngredients)
                {
                    break;
                }


            }
            Console.WriteLine($"Total calories: {totalCalories}");
            return;

        }
    }
}
