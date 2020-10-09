using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            names = names.Select(n => $"Sir {n}").ToList();

            Action<List<string>> printNames = list => Console.WriteLine(string.Join(Environment.NewLine, list));

            printNames(names);
        }
    }
}
