using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, bool> filter = x => x.Length <= length;
            names = names.Where(filter).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
