using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int count = 0;

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                    count = 0;
                }
                else
                {
                    queue.Enqueue(input);
                    count++;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} people remaining.");
        }
    }
}
