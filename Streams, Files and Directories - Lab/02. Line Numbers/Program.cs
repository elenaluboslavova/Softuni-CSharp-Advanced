using System;
using System.IO;
using System.Xml;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader("../../../Input.txt"))
            {
                using(var writer = new StreamWriter("../../../Output.txt"))
                {
                    var line = reader.ReadLine();
                    int index = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{index}. {line}");
                        Console.WriteLine($"{index}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
