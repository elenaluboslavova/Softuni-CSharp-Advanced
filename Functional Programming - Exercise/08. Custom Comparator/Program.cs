using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //Array.Sort(numbers, (x, y) =>
            //{
            //    int sorter = 0;
            //    if (x % 2 == 0 && y % 2 != 0)
            //    {
            //        sorter = - 1;
            //    }
            //    else if(x % 2 != 0 && y % 2 == 0)
            //    {
            //        sorter = 0;
            //    }
            //    else
            //    {
            //        sorter = x - y;
            //    }

            //    return sorter;
            //});

            Array.Sort(numbers, (x, y) => 
            (x % 2 == 0 && y % 2 != 0) ? -1 : 
            (x % 2 != 0 && y % 2 == 0) ? 1 : 
            x.CompareTo(y));

            Console.WriteLine(string.Join(" ", numbers));
        }
        
    }

}
