using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool didOccur = false;
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (matrix[rows, cols] == symbol)
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        didOccur = true;
                        Environment.Exit(0);
                    }
                }
            }
            if (!didOccur)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix ");
            }
        }
    }
}
