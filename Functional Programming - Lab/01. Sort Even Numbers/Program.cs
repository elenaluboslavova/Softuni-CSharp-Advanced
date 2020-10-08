using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] sorted = numbers.Where(x => x % 2 != 1).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(", ", sorted));
        }
    }
}
