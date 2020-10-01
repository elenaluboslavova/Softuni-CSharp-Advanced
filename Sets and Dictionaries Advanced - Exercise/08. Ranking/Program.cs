using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(":");

            Dictionary<string, string> contests = new Dictionary<string, string>();

            while (command[0] != "end of contests")
            {
                string contest = command[0];
                string password = command[1];
                contests.Add(contest, password);

                command = Console.ReadLine().Split(":");
            }

            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            string[] input = Console.ReadLine().Split("=>");
            while (input[0] != "end of submissions")
            {
                string contest = input[0];
                string password = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new Dictionary<string, int>());
                    }
                    if (!users[username].ContainsKey(contest))
                    {
                        users[username].Add(contest, 0);
                    }
                    if (points > users[username][contest])
                    {
                        users[username][contest] = points;
                    }
                }

                input = Console.ReadLine().Split("=>");
            }
            if (users.Count > 0)
            {
                int maxPoints = int.MinValue;
                string maxUser = "";

                foreach (var item in users)
                {
                    foreach (var pair in item.Value)
                    {
                        int sum = 0;
                        foreach (var grade in item.Value.Values)
                        {
                            sum += grade;
                        }
                        if (sum > maxPoints)
                        {
                            maxPoints = sum;
                            maxUser = item.Key;
                        }
                    }
                }

                Console.WriteLine($"Best candidate is {maxUser} with total {maxPoints} points.");
                Console.WriteLine("Ranking:");
                foreach (var item in users.OrderBy(x => x.Key))
                {
                    Console.WriteLine(item.Key);
                    foreach (var pair in item.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                    }
                }
            }
            
        }
    }
}
