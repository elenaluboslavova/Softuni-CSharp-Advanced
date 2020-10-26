using System;
using System.IO;

namespace _02._Bee
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
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int currentRow = 0;
            int currentCol = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[j, i] == 'B')
                    {
                        currentRow = j;
                        currentCol = i;
                    }
                }
            }
            string command = Console.ReadLine();
            int pollinatedFlowers = 0;

            while (command != "End")
            {
                switch (command)
                {
                    case "up":
                        if (currentRow - 1 >= 0)
                        {
                            if (matrix[currentRow - 1, currentCol] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow - 1, currentCol] = 'B';
                                currentRow = currentRow - 1;
                            }
                            else if (matrix[currentRow - 1, currentCol] == 'O')
                            {
                                if (matrix[currentRow - 2, currentCol] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                                matrix[currentRow - 2, currentCol] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow - 1, currentCol] = '.';
                                currentRow = currentRow - 2;
                            }
                            else
                            {
                                matrix[currentRow - 1, currentCol] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                currentRow = currentRow - 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            matrix[currentRow, currentCol] = '.';
                            goto End;
                        }
                        break;

                    case "down":
                        if (currentRow + 1 < matrix.GetLength(0))
                        {
                            if (matrix[currentRow + 1, currentCol] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow + 1, currentCol] = 'B';
                                currentRow = currentRow + 1;
                            }
                            else if (matrix[currentRow + 1, currentCol] == 'O')
                            {
                                if (matrix[currentRow + 2, currentCol] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                                matrix[currentRow + 2, currentCol] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow + 1, currentCol] = '.';
                                currentRow = currentRow + 2;
                            }
                            else
                            {
                                matrix[currentRow + 1, currentCol] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                currentRow = currentRow + 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            matrix[currentRow, currentCol] = '.';
                            goto End;
                        }
                        break;

                    case "left":
                        if (currentCol - 1 >= 0)
                        {
                            if (matrix[currentRow, currentCol - 1] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow, currentCol - 1] = 'B';
                                currentCol = currentCol - 1;
                            }
                            else if (matrix[currentRow, currentCol - 1] == 'O')
                            {
                                if (matrix[currentRow, currentCol - 2] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                                matrix[currentRow, currentCol - 2] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow, currentCol - 1] = '.';
                                currentCol = currentCol - 2;
                            }
                            else
                            {
                                matrix[currentRow, currentCol - 1] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                currentCol = currentCol - 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            matrix[currentRow, currentCol] = '.';
                            goto End;
                        }
                        break;

                    case "right":
                        if (currentCol + 1 < matrix.GetLength(1))
                        {
                            if (matrix[currentRow, currentCol + 1] == 'f')
                            {
                                pollinatedFlowers++;
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow, currentCol + 1] = 'B';
                                currentCol = currentCol + 1;
                            }
                            else if (matrix[currentRow, currentCol + 1] == 'O')
                            {
                                if (matrix[currentRow, currentCol + 2] == 'f')
                                {
                                    pollinatedFlowers++;
                                }
                                matrix[currentRow, currentCol + 2] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                matrix[currentRow, currentCol + 1] = '.';
                                currentCol = currentCol + 2;
                            }
                            else
                            {
                                matrix[currentRow, currentCol + 1] = 'B';
                                matrix[currentRow, currentCol] = '.';
                                currentCol = currentCol + 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The bee got lost!");
                            matrix[currentRow, currentCol] = '.';
                            goto End;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            End:
            if (pollinatedFlowers >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
