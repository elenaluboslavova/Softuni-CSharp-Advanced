using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            while (queue.Count > 0)
            {
                int current = queue.Peek();
                if (quantity >= current)
                {
                    quantity -= current;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            
            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
