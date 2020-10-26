using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liliesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] rosesInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Stack<int> lilies = new Stack<int>(liliesInput);
            Queue<int> roses = new Queue<int>(rosesInput);


            int currentSum = 0;
            int wreathsCount = 0;
            int storedFlowers = 0;

            while (lilies.Count > 0 || roses.Count > 0)
            {
                currentSum = 0;
                int curretLilly = lilies.Peek();
                int currentRose = roses.Peek();
                currentSum = curretLilly + currentRose;

                if (currentSum == 15)
                {
                    wreathsCount++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (currentSum > 15)
                {
                    int temp = curretLilly - 2;
                    lilies.Pop();
                    Stack<int> tempStack = new Stack<int>();
                    tempStack.Push(temp);
                    int count = lilies.Count;
                    for (int i = 0; i < count; i++)
                    {
                        tempStack.Push(lilies.Pop());
                    }
                    lilies.Clear();
                    int count2 = tempStack.Count;
                    for (int i = 0; i < count2; i++)
                    {
                        lilies.Push(tempStack.Pop());
                    }
                    tempStack.Clear();
                }
                else
                {
                    storedFlowers += lilies.Pop();
                    storedFlowers += roses.Dequeue();
                }
            }

            if (storedFlowers > 0)
            {
                int countOfNewWreaths = storedFlowers / 15;
                wreathsCount += countOfNewWreaths;
            }
            if (wreathsCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreathsCount} wreaths more!");
            }
        }
    }
}
