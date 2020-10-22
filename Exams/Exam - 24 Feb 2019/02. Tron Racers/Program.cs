using System;

namespace _02._Tron_Racers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int firstRow = 0;
            int firstCol = 0;
            int secondRow = 0;
            int secondCol = 0;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = line[j];
                    if (line[j] == 'f')
                    {
                        firstRow = i;
                        firstCol = j;
                    }
                    else if (line[j] == 's')
                    {
                        secondRow = i;
                        secondCol = j;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstCommand = input[0];
                string secondCommand = input[1];


                if (firstCommand == "up")
                {
                    if (matrix[firstRow - 1,firstCol] == 's')
                    {

                    }
                    matrix[firstRow, firstCol] = 'f';
                    if (firstRow - 1 < 0)
                    {
                        firstRow = n - 1;
                    }
                    else
                    {
                        firstRow -= 1;
                    }
                    if (matrix[firstRow, firstCol] == 's')
                    {
                        matrix[firstRow, firstCol] = 'x';
                        break;
                    }
                    matrix[firstRow, firstCol] = 'f';
                }
                else if (firstCommand == "down")
                {
                    matrix[firstRow, firstCol] = 'f';
                    if (firstRow + 1 == n)
                    {
                        firstRow = 0;
                    }
                    else
                    {
                        firstRow += 1;
                    }
                    if (matrix[firstRow, firstCol] == 's')
                    {
                        matrix[firstRow, firstCol] = 'x';
                        break;
                    }
                    matrix[firstRow, firstCol] = 'f';
                }
                else if (firstCommand == "left")
                {
                    matrix[firstRow, firstCol] = 'f';
                    if (firstCol - 1 < 0)
                    {
                        firstCol = n - 1;
                    }
                    else
                    {
                        firstCol -= 1;
                    }
                    if (matrix[firstRow, firstCol] == 's')
                    {
                        matrix[firstRow, firstCol] = 'x';
                        break;
                    }
                    matrix[firstRow, firstCol] = 'f';
                }
                else if (firstCommand == "right")
                {
                    matrix[firstRow, firstCol] = 'f';
                    if (firstCol + 1 == n)
                    {
                        firstCol = 0;
                    }
                    else
                    {
                        firstCol += 1;
                    }
                    if (matrix[firstRow, firstCol] == 's')
                    {
                        matrix[firstRow, firstCol] = 'x';
                        break;
                    }
                    matrix[firstRow, firstCol] = 'f';
                }

                if (secondCommand == "up")
                {
                    matrix[secondRow, secondCol] = 's';
                    if (secondRow - 1 < 0)
                    {
                        secondRow = n - 1;
                    }
                    else
                    {
                        secondRow -= 1;
                    }
                    if (matrix[secondRow, secondCol] == 'f')
                    {
                        matrix[secondRow, secondCol] = 'x';
                        break;
                    }
                    matrix[secondRow, secondCol] = 's';
                }
                else if (secondCommand == "down")
                {
                    matrix[secondRow, secondCol] = 's';
                    if (secondRow + 1 == n)
                    {
                        secondRow = 0;
                    }
                    else
                    {
                        secondRow += 1;
                    }
                    if (matrix[secondRow, secondCol] == 'f')
                    {
                        matrix[secondRow, secondCol] = 'x';
                        break;
                    }
                    matrix[secondRow, secondCol] = 's';
                }
                else if (secondCommand == "left")
                {
                    matrix[secondRow, secondCol] = 's';
                    if (secondCol - 1 < 0)
                    {
                        secondCol = n - 1;
                    }
                    else
                    {
                        secondCol -= 1;
                    }
                    if (matrix[secondRow, secondCol] == 'f')
                    {
                        matrix[secondRow, secondCol] = 'x';
                        break;
                    }
                    matrix[secondRow, secondCol] = 's';
                }
                else if (secondCommand == "right")
                {
                    matrix[secondRow, secondCol] = 's';
                    if (secondCol + 1 == n)
                    {
                        secondCol = 0;
                    }
                    else
                    {
                        secondCol += 1;
                    }
                    if (matrix[secondRow, secondCol] == 'f')
                    {
                        matrix[secondRow, secondCol] = 'x';
                        break;
                    }
                    matrix[secondRow, secondCol] = 's';
                }
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
