using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 0);
                }
                dict[input[i]]++;
            }
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
