using System;

namespace _02._Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int playerRow = 0;
            int playerCol = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                    if (input[j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }

            
            bool hasWon = false;

            for (int i = 0; i < commandsCount; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    matrix[playerRow, playerCol] = '-';
                    if (playerRow - 1 < 0)
                    {
                        playerRow = n - 1;
                    }
                    else
                    {
                        playerRow--;
                    }
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow -= 1;
                        if (playerRow - 1 < 0)
                        {
                            playerRow = n - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow += 1;
                        if (playerRow == n)
                        {
                            playerRow = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        hasWon = true;
                        break;
                    }
                    matrix[playerRow, playerCol] = 'f';
                }
                else if (command == "down")
                {
                    matrix[playerRow, playerCol] = '-';
                    if (playerRow + 1 == n)
                    {
                        playerRow = 0;
                    }
                    else
                    {
                        playerRow++;
                    }
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerRow += 1;
                        if (playerRow + 1 == n)
                        {
                            playerRow = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerRow -= 1;
                        if (playerRow < 0)
                        {
                            playerRow = n - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        hasWon = true;
                        break;
                    }
                    matrix[playerRow, playerCol] = 'f';
                }
                else if (command == "left")
                {
                    matrix[playerRow, playerCol] = '-';
                    if (playerCol - 1 < 0)
                    {
                        playerCol = n - 1;
                    }
                    else
                    {
                        playerCol--;
                    }
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol -= 1;
                        if (playerCol - 1 < 0)
                        {
                            playerCol = n - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol += 1;
                        if (playerCol == n)
                        {
                            playerCol = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        hasWon = true;
                        break;
                    }
                    matrix[playerRow, playerCol] = 'f';
                }
                else if (command == "right")
                {
                    matrix[playerRow, playerCol] = '-';
                    if (playerCol + 1 == n)
                    {
                        playerCol = 0;
                    }
                    else
                    {
                        playerCol++;
                    }
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        playerCol += 1;
                        if (playerCol + 1 == n)
                        {
                            playerCol = 0;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'T')
                    {
                        playerCol -= 1;
                        if (playerCol < 0)
                        {
                            playerCol = n - 1;
                        }
                    }
                    else if (matrix[playerRow, playerCol] == 'F')
                    {
                        matrix[playerRow, playerCol] = 'f';
                        Console.WriteLine("Player won!");
                        hasWon = true;
                        break;
                    }
                    matrix[playerRow, playerCol] = 'f';
                }
            }
            if (!hasWon)
            {
                Console.WriteLine("Player lost!");
            }
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
