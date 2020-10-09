using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();
            List<string> filters = new List<string>();

            while (command != "Print")
            {
                string[] tokens = command.Split(";");
                string commandName = tokens[0];
                string filterType = tokens[1];
                string argument = tokens[2];

                if (commandName == "Add filter")
                {
                    filters.Add($"{filterType};{argument}");
                }
                else if (commandName == "Remove filter")
                {
                    filters.Remove($"{filterType};{argument}");
                }

                command = Console.ReadLine();
            }

            foreach (var filterLine in filters)
            {
                string[] tokens = filterLine.Split(";");
                string filterType = tokens[0];
                string argument = tokens[1];

                switch (filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();
                        break;
                    case "Length":
                        people = people.Where(p => p.Length != int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;
                }
                
            }
            Console.WriteLine(string.Join(" ", people));
        }
    }
}
