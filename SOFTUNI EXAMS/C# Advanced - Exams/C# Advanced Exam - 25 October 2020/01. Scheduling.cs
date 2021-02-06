using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{


    class Program
    {

        static void Main(string[] args)
        {
            Queue<int> tasks = new Queue<int>
            (Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .Reverse()
                 .ToList());




            Queue<int> threads = new Queue<int>
                (Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList());



            int taskToKill = int.Parse(Console.ReadLine());



            while (tasks.Count > 0)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if (currentTask <= currentThread)
                {
                    threads.Dequeue();
                    tasks.Dequeue();
                }
                if (currentTask > currentThread)
                {
                    threads.Dequeue();
                }
                if (taskToKill == currentTask)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {currentTask}");
                    Console.WriteLine($"{currentThread} {string.Join(" ", threads)}");
                    break;
                }
                else
                {

                }

            }
        }
    }
}