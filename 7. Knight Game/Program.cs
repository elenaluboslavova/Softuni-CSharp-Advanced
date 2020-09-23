using System;
using System.Runtime.InteropServices;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    chessBoard[i, j] = input[j];
                }
            }

            int countReplaced = 0;
            int maxRow = 0;
            int maxCol = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char current = chessBoard[row, col];
                        int countAttacks = 0;
                        if (current == 'K')
                        {
                            countAttacks = GetAttacks(chessBoard, row, col, countAttacks);
                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[maxRow, maxCol] = '0';
                    countReplaced++;
                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }
        }

        private static int GetAttacks(char[,] chessBoard, int row, int col, int countAttacks)
        {
            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
            {
                countAttacks++;
            }

            return countAttacks;
        }

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0) && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
        }
    }
}
