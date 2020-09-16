using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string[] command = Console.ReadLine().Split(" ").ToArray();
            string comand = command[0].ToLower();

            while (comand != "end")
            {
                if (comand == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else
                {
                    if (int.Parse(command[1]) <= stack.Count)
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().Split(" ").ToArray();
                comand = command[0].ToLower();
            }
            int sum = 0;
            foreach (var item in stack)
            {
                sum += item;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
