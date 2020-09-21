using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            
            int sum = 0;
            for (int row = 0; row < sizes[0]; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = data[col];
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            Console.WriteLine(sum);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ReadMatrix(int[] sizes)
        {
            sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}
