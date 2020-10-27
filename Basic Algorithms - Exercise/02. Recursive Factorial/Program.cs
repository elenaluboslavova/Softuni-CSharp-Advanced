using System;

namespace _02._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return n;
            }
            int result = n * Factorial(n - 1);
            return result;
        }
    }
}
