﻿using System;

namespace _01.GenericBoxofString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string currentValue = Console.ReadLine();

                Box<string> box = new Box<string>(currentValue);

                Console.WriteLine(box.ToString());
                //Console.WriteLine(box);
            }
        }
    }
}
