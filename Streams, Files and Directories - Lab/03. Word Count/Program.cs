using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            string inputWords = File.ReadAllText("../../../words.txt");
            string[] words = inputWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            String pattern = @"[a-zA-Z']+";
            Regex regex = new Regex(pattern);


            using (var reader = new StreamReader("../../../text.txt"))
            {
                string currentSentence = reader.ReadLine();

                while (currentSentence != null)
                {

                    foreach (Match match in regex.Matches(currentSentence))
                    {
                        for (int i = 0; i < words.Length; i++)
                        {

                            if (match.Value.ToLower() == words[i] && !(dictionary.ContainsKey(words[i])))
                            {
                                dictionary.Add(words[i], 1);
                            }


                            else if (match.Value.ToLower() == words[i])
                            {
                                dictionary[words[i]]++;
                            }

                        }

                    }
                    currentSentence = reader.ReadLine();
                }

                foreach (var item in dictionary.OrderByDescending(key => key.Value))
                {
                    Console.WriteLine("{0} - {1}", item.Key, item.Value);
                }
            }

        }
    }
}
