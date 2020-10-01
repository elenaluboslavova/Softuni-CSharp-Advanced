using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> set = new HashSet<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!set.Contains(num))
                {
                    set.Add(num);
                }
                else
                {
                    if (!dict.ContainsKey(num))
                    {
                        dict.Add(num, 0);
                    }
                    dict[num]++;
                }
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
