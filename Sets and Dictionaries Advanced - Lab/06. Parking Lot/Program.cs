using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> set = new HashSet<string>();

            while (command != "END")
            {
                string direction = command.Split(", ")[0];
                string number = command.Split(", ")[1];

                if (direction == "IN")
                {
                    set.Add(number);
                }
                else
                {
                    if (set.Contains(number))
                    {
                        set.Remove(number);
                    }
                }

                command = Console.ReadLine();
            }
            if (set.Count > 0)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
