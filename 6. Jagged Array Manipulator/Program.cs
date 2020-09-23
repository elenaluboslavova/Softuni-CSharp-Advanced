using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i].Length == matrix[i+1].Length)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] *= 2;
                        matrix[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] /= 2;
                    }
                    for (int j = 0; j < matrix[i+1].Length; j++)
                    {
                        matrix[i+1][j] /= 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                int row = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                int col = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2]);
                int value = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3]);

                if (row >= 0 && row < rows && col >= 0 && col < matrix[row].Length)
                {
                    if (command.Split()[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (command.Split()[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                

                command = Console.ReadLine();
            }
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
    }
}
