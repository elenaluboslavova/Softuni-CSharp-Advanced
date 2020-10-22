using System;

namespace _02._Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int snakeRow = 0;
            int snakeCol = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == 'S')
                    {
                        snakeRow = i;
                        snakeCol = j;
                    }
                }
            }

            bool isFed = false;
            int foodQuantity = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (snakeRow - 1 >= 0)
                    {
                        if (matrix[snakeRow-1, snakeCol] == '*')
                        {
                            foodQuantity++;
                            matrix[snakeRow, snakeCol] = '.';
                            snakeRow -= 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else if (matrix[snakeRow-1,snakeCol] == 'B')
                        {
                            matrix[snakeRow - 1, snakeCol] = '.';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i,j] == 'B')
                                    {
                                        snakeRow = i;
                                        snakeCol = j;
                                        matrix[i, j] = '.';
                                    }
                                }
                                matrix[snakeRow, snakeCol] = 'S';
                            }
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            snakeRow -= 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (snakeRow + 1 < n)
                    {
                        if (matrix[snakeRow + 1, snakeCol] == '*')
                        {
                            foodQuantity++;
                            matrix[snakeRow, snakeCol] = '.';
                            snakeRow += 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else if (matrix[snakeRow + 1, snakeCol] == 'B')
                        {
                            matrix[snakeRow + 1, snakeCol] = '.';
                            matrix[snakeRow, snakeCol] = '.';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        snakeRow = i;
                                        snakeCol = j;
                                        matrix[i, j] = '.';
                                    }
                                }
                                
                            }
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            snakeRow += 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (snakeCol - 1 >= 0)
                    {
                        if (matrix[snakeRow, snakeCol - 1] == '*')
                        {
                            foodQuantity++;
                            matrix[snakeRow, snakeCol] = '.';
                            snakeCol -= 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else if (matrix[snakeRow, snakeCol - 1] == 'B')
                        {
                            matrix[snakeRow, snakeCol - 1] = '.';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        snakeRow = i;
                                        snakeCol = j;
                                        matrix[i, j] = '.';
                                    }
                                }
                            }
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            snakeCol -= 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (snakeCol + 1 < n)
                    {
                        if (matrix[snakeRow, snakeCol + 1] == '*')
                        {
                            foodQuantity++;
                            matrix[snakeRow, snakeCol] = '.';
                            snakeCol += 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else if (matrix[snakeRow, snakeCol + 1] == 'B')
                        {
                            matrix[snakeRow, snakeCol + 1] = '.';
                            for (int i = 0; i < n; i++)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    if (matrix[i, j] == 'B')
                                    {
                                        snakeRow = i;
                                        snakeCol = j;
                                        matrix[i, j] = '.';
                                    }
                                }
                            }
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                        else
                        {
                            matrix[snakeRow, snakeCol] = '.';
                            snakeCol += 1;
                            matrix[snakeRow, snakeCol] = 'S';
                        }
                    }
                    else
                    {
                        matrix[snakeRow, snakeCol] = '.';
                        break;
                    }
                }

                if (foodQuantity >= 10)
                {
                    isFed = true;
                    break;
                }
            }

            if (isFed)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
            Console.WriteLine($"Food eaten: {foodQuantity}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
