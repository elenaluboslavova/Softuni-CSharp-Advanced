using System;
using System.IO.Compression;

namespace _06._Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"D:\ZipDemo", @"D:\ZipDemo2\myZipFile.zip");
            ZipFile.ExtractToDirectory(@"D:\ZipDemo2\myZipFile.zip", @"D:\ZipDemo3");
        }
    }
}
