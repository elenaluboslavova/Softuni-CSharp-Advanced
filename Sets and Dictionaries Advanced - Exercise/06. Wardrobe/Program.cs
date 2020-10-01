using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentCloth = clothes[j];
                    if (!dict[color].ContainsKey(currentCloth))
                    {
                        dict[color].Add(currentCloth, 0);
                    }
                    dict[color][currentCloth]++;
                }
            }
            string[] command = Console.ReadLine().Split();
            string neededColor = command[0];
            string neededCloth = command[1];

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var pair in item.Value)
                {
                    if (item.Key == neededColor && pair.Key == neededCloth)
                    {
                        Console.WriteLine($"* {pair.Key} - {pair.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {pair.Key} - {pair.Value}");
                    }
                }
            }

        }
    }
}
