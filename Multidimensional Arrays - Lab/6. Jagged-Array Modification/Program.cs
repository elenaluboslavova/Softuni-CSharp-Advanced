using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                jaggedMatrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] input = command.Split();
                string action = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if ((row >= n || row < 0) || (col > jaggedMatrix[row].Length - 1 || col < 0))
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (action)
                    {
                        case "Add":
                            jaggedMatrix[row][col] += value;
                            break;

                        case "Subtract":
                            jaggedMatrix[row][col] -= value;
                            break;
                    }
                }
                

                command = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(jaggedMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
