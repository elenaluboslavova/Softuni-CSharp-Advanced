using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> list = new List<int>();
            
            for (int i = 1; i <= n; i++)
            {
                bool isT = true;

                foreach (var item in numbers)
                {
                    Predicate<int> isDivisible = x => i % x == 0;

                    if (!isDivisible(item))
                    {
                        isT = false;
                        break;
                    }
                }
                if (isT)
                {
                    list.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
