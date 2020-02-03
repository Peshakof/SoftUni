﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.Dictionaries__Lambda_and_LINQ___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] commands = Console.ReadLine()
                .Split(' ')
                .ToArray();

            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    if (!phonebook.ContainsKey(commands[1]))
                    {
                        phonebook.Add(commands[1], commands[2]);
                    }
                    else
                    {
                        phonebook[commands[1]] = commands[2];
                    }
                }
                else if (commands[0] == "S")
                {
                    if (!phonebook.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"Contact {commands[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
                    }
                }  
                commands = Console.ReadLine().Split(' ').ToArray();

            }
        }
    }
}
