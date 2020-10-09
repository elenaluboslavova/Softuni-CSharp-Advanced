using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            Func<int, bool> removeElement = x => x % number != 0;
            list = list.Where(removeElement).Reverse().ToList();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
