using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");

            List<string> list = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (!list.Contains(word))
                {
                    list.Add(word);
                }
            }

            string[] text = File.ReadAllLines("../../../text.txt");

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string[] current = text[i].Split(new char[] { ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < current.Length; j++)
                {
                    if (list.Contains(current[j].ToLower()))
                    {
                        if (!dict.ContainsKey(current[j].ToLower()))
                        {
                            dict.Add(current[j].ToLower(), 1);
                        }
                        else
                        {
                            dict[current[j].ToLower()]++;
                        }
                    }
                }
            }

            List<string> currents = new List<string>();
            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                string current = $"{item.Key} - {item.Value}";
                currents.Add(current);
                File.WriteAllLines("../../../actualResult.txt", currents);
            }
        }
    }
}
