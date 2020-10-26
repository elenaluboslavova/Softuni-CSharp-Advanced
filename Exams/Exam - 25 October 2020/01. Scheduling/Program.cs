using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksInput = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] threadsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int taskToBeKilled = int.Parse(Console.ReadLine());

            Stack<int> tasks = new Stack<int>(tasksInput);
            Queue<int> threads = new Queue<int>(threadsInput);

            while (tasks.Count > 0 && threads.Count > 0)
            {
                int currentThread = threads.Peek();
                int currentTask = tasks.Peek();

                if (currentTask == taskToBeKilled)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskToBeKilled}");
                    Console.WriteLine(string.Join(" ", threads));
                    break;
                }
                if (currentThread >= currentTask)
                {
                    threads.Dequeue();
                    tasks.Pop();
                }
                else
                {
                    threads.Dequeue();
                }

            }

        }
    }
}
