using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> reservations = new HashSet<string>();

            while (true)
            {
                if (input == "PARTY")
                {
                    while (input != "END")
                    {
                        reservations.Remove(input);
                        input = Console.ReadLine();
                    }
                    Console.WriteLine(reservations.Count);
                    foreach (var item in reservations)
                    {
                        Console.WriteLine(item);
                    }
                    Environment.Exit(0);
                }
                else if (input.Length == 8 || char.IsDigit(input[0]))
                {
                    reservations.Add(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}
