using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizes[0];
            int cols = sizes[1];

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            Queue<char> queue = new Queue<char>(snake);

            string direction = "left";
            int rowPosition = 0;

            while (rowPosition < rows)
            {
                if (direction == "left")
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[rowPosition, col] = queue.Dequeue();
                        if (queue.Count == 0)
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }
                    }
                    direction = "right";
                    rowPosition++;

                }
                else if (direction == "right")
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[rowPosition, col] = queue.Dequeue();
                        if (queue.Count == 0)
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }
                    }
                    direction = "left";
                    rowPosition++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
