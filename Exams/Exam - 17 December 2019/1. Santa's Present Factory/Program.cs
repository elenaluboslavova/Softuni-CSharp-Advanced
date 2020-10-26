using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boxesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] magicValuesInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Dictionary<string, int> presents = new Dictionary<string, int>();

            Stack<int> boxes = new Stack<int>(boxesInput);
            Queue<int> magicValues = new Queue<int>(magicValuesInput);

            while (boxes.Count > 0 && magicValues.Count > 0)
            {
                int currentBox = boxes.Peek();
                int currentMagicValue = magicValues.Peek();
                int sum = currentBox * currentMagicValue;

                if (currentBox == 0 && currentMagicValue == 0)
                {
                    boxes.Pop();
                    magicValues.Dequeue();
                    continue;
                }
                else if (currentBox == 0)
                {
                    boxes.Pop();
                    continue;
                }
                else if (currentMagicValue == 0)
                {
                    magicValues.Dequeue();
                    continue;
                }
                

                if (sum == 150)
                {
                    if (!presents.ContainsKey("Doll"))
                    {
                        presents.Add("Doll", 0);
                    }
                    presents["Doll"]++;
                    boxes.Pop();
                    magicValues.Dequeue();
                }
                else if (sum == 250)
                {
                    if (!presents.ContainsKey("Wooden train"))
                    {
                        presents.Add("Wooden train", 0);
                    }
                    presents["Wooden train"]++;
                    boxes.Pop();
                    magicValues.Dequeue();
                }
                else if (sum == 300)
                {
                    if (!presents.ContainsKey("Teddy bear"))
                    {
                        presents.Add("Teddy bear", 0);
                    }
                    presents["Teddy bear"]++;
                    boxes.Pop();
                    magicValues.Dequeue();
                }
                else if (sum == 400)
                {
                    if (!presents.ContainsKey("Bicycle"))
                    {
                        presents.Add("Bicycle", 0);
                    }
                    presents["Bicycle"]++;
                    boxes.Pop();
                    magicValues.Dequeue();
                }
                else if (sum < 0)
                {
                    int tempSum = currentBox + currentMagicValue;
                    boxes.Pop();
                    magicValues.Dequeue();
                    boxes.Push(tempSum);
                }
                else
                {
                    magicValues.Dequeue();
                    int temp = currentBox + 15;
                    boxes.Pop();
                    boxes.Push(temp);
                }
            }
            bool hasPresents = (presents.ContainsKey("Doll") && presents.ContainsKey("Wooden train")) || (presents.ContainsKey("Teddy bear") && presents.ContainsKey("Bicycle"));
            if (hasPresents)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            if (boxes.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", boxes)}");
            }
            if (magicValues.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicValues)}");
            }
            if (presents.Count > 0)
            {
                foreach (var present in presents.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{present.Key}: {present.Value}");
                }
            }
        }
    }
}
