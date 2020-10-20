using System;
using System.Runtime.ExceptionServices;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstTokens = Console.ReadLine().Split();
            string personFullName = firstTokens[0] + " " + firstTokens[1];
            string personAddress = firstTokens[2];
            Tuple<string, string> personInfo = new Tuple<string, string>(personFullName, personAddress);
            Console.WriteLine(personInfo);

            string[] secondTokens = Console.ReadLine().Split();
            string name = secondTokens[0];
            int count = int.Parse(secondTokens[1]);
            Tuple<string, int> personBeersCount = new Tuple<string, int>(name, count);
            Console.WriteLine(personBeersCount);

            string[] thirdTokens = Console.ReadLine().Split();
            int first = int.Parse(thirdTokens[0]);
            double second = double.Parse(thirdTokens[1]);
            Tuple<int, double> numbers = new Tuple<int, double>(first, second);
            Console.WriteLine(numbers);
        }
    }
}
