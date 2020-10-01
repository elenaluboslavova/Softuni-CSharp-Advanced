using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < lengths[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < lengths[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            var set3 = set1.Intersect(set2);
            Console.WriteLine(string.Join(" ", set3));
        }
    }
}
