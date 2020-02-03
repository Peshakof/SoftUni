using System;

namespace Problem_5._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            var result = "unknown";

            switch(country)

            {
                case "England":
                case "USA":
                    result = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                   result = "Spanish";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
