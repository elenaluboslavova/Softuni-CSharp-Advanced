using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(cups);
            Stack<int> stack = new Stack<int>(bottles);
            int wastedWater = 0;

            while (queue.Count > 0 && stack.Count > 0)
            {
                int currentCup = queue.Peek();
                int currentBottle = stack.Peek();

                if (currentCup - currentBottle <= 0)
                {
                    queue.Dequeue();
                    stack.Pop();
                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    currentCup -= currentBottle;
                    stack.Pop();
                }
            }
            if (queue.Count == 0 && stack.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stack)}");
            }
            if (stack.Count == 0 && queue.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", queue)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
