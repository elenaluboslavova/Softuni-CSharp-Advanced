using System;
using System.IO;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();
            Console.WriteLine(GetDirectorySize(directoryPath,0));
        }

        static double GetDirectorySize(string directoryPath, int identation)
        {
            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;

            string[] directories = Directory.GetDirectories(directoryPath);
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine($"{new string(' ', identation)}{directories[i]}");
                sum += GetDirectorySize(directories[i], identation + 5);
            }

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                Console.WriteLine($"{new string('-',identation)}{info.Name} --> {info.Length} bytes");
                sum += info.Length;
            }
            return sum;
        }
    }
}
