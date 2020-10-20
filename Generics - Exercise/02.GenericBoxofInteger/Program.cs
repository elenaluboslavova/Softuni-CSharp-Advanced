using System;

namespace _02.GenericBoxofInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentValue = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(currentValue);

                Console.WriteLine(box.ToString());
                //Console.WriteLine(box);
            }
        }
    }
}
