using System;
using System.Collections.Generic;
using System.IO;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            int counter = 0;
            bool isCrashed = false;

            int totalGreen = greenLight + freeWindow;

            while (input != "END")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else if(input == "green" && queue.Count > 0)
                {
                    totalGreen = greenLight + freeWindow;
                    while (queue.Count > 0)
                    {
                        string current = queue.Peek();
                        if (totalGreen < 0)
                        {
                            goto End;
                        }
                        if (current.Length <= totalGreen)
                        {
                            queue.Dequeue();
                            totalGreen -= current.Length;
                            counter++;
                        }
                        else
                        {
                            isCrashed = true;
                            int index = totalGreen;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{current} was hit at {current[index]}.");
                            Environment.Exit(0);
                        }
                    }
                    
                }

                input = Console.ReadLine();
            }
            End:
            if (!isCrashed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}
