using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffectsInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[] bombCasingsInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int counter1 = 0;
            for (int i = 0; i < bombEffectsInput.Length; i++)
            {
                if (bombEffectsInput[i] == 0)
                {
                    counter1++;
                }
            }
            int counter2 = 0;
            for (int i = 0; i < bombCasingsInput.Length; i++)
            {
                if (bombCasingsInput[i] == 0)
                {
                    counter2++;
                }
            }
            if (counter1 == bombEffectsInput.Length && counter2 == bombCasingsInput.Length)
            {
                Environment.Exit(0);
            }

            Queue<int> bombEffects = new Queue<int>(bombEffectsInput);
            Stack<int> bombCasings = new Stack<int>(bombCasingsInput);

            int sum = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Datura Bombs", 0);
            dict.Add("Cherry Bombs", 0);
            dict.Add("Smoke Decoy Bombs", 0);
            bool isFilled = false;

            while (bombEffects.Count > 0 || bombCasings.Count > 0)
            {
                sum = 0;
                int currentBombEffect = bombEffects.Peek();
                int currentBombCasing = bombCasings.Peek();
                sum += currentBombEffect + currentBombCasing;
                if (sum < 40)
                {
                    Environment.Exit(0);
                }

                if (sum == 40)
                {
                    dict["Datura Bombs"]++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (sum == 60)
                {
                    dict["Cherry Bombs"]++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (sum == 120)
                {
                    dict["Smoke Decoy Bombs"]++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    int temp = currentBombCasing - 5;
                    bombCasings.Pop();
                    Stack<int> tempStack = new Stack<int>();
                    tempStack.Push(temp);
                    int count = bombCasings.Count;
                    for (int i = 0; i < count; i++)
                    {
                        tempStack.Push(bombCasings.Pop());
                    }
                    bombCasings.Clear();
                    int count2 = tempStack.Count;
                    for (int i = 0; i < count2; i++)
                    {
                        bombCasings.Push(tempStack.Pop());
                    }
                    tempStack.Clear();
                }
                if (dict.ContainsKey("Datura Bombs") && dict.ContainsKey("Cherry Bombs") && dict.ContainsKey("Smoke Decoy Bombs"))
                {
                    isFilled = dict["Datura Bombs"] >= 3 && dict["Cherry Bombs"] >= 3 && dict["Smoke Decoy Bombs"] >= 3;
                    if (isFilled)
                    {
                        break;
                    }
                }

            }

            if (isFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }

            if (bombCasings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
