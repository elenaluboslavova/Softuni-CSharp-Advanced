using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstBoxInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] secondBoxInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> firstBox = new Queue<int>(firstBoxInput);
            Stack<int> secondBox = new Stack<int>(secondBoxInput);

            int sumClaimedItems = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {
                int currentFirstBox = firstBox.Peek();
                int currentSecondBox = secondBox.Peek();

                int currentSum = currentFirstBox + currentSecondBox;

                if (currentSum % 2 == 0)
                {
                    sumClaimedItems += currentSum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }
            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sumClaimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumClaimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumClaimedItems}");
            }
        }
    }
}
