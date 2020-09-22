﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                if (command.Contains("1 "))
                {
                    string num = command.Split("1 ", StringSplitOptions.RemoveEmptyEntries)[0];
                    int number = int.Parse(num);
                    stack.Push(number);
                }
                else if (command.Contains("2"))
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command.Contains("3"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    
                }
                else if (command.Contains("4"))
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                    
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
