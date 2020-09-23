using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int sum1 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
            }

            int sum2 = 0;
            int counter = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                sum2 += matrix[counter, i];
                counter++;
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
