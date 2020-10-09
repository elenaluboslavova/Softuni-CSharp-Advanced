using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> people = Console.ReadLine().Split().ToList();

            Func<string, int> getAsciiSum = p => p.Select(c => (int)c).Sum();

            Func<List<string>, int, Func<string, int>, string> nameFunc = (people, n, func) => people.FirstOrDefault(p => func(p) >= n);

            string result = nameFunc(people, n, getAsciiSum);
            Console.WriteLine(result);
        }

        static string GetName(List<string> people, int n, Func<string, int> func)
        {
            string result = null;
            foreach (string person in people)
            {
                if (func(person) >= n)
                {
                    result = person;
                }
            }
            return result;
        }
    }
}
