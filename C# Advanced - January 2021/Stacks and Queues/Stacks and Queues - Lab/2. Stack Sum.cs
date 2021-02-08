using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StackSum

{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse);
            var stack = new Stack<int>(numbers);
            while (true)
            {
                var command = Console.ReadLine().ToLower().Trim();
                if (command.StartsWith("add"))
                {
                    var parts = command.Split(' ');
                    stack.Push(int.Parse(parts[1]));
                    stack.Push(int.Parse(parts[2]));
                }
                else if (command.StartsWith("remove"))
                {
                    var parts = command.Split(' ');
                    var itemsToRemove = int.Parse(parts[1]);
                    if (stack.Count >= itemsToRemove)
                    {

                        for (int i = 0; i < itemsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
                else if (command.StartsWith("end"))
                {
                    var result = stack.Sum();
                    Console.WriteLine("Sum: " + result);
                    break;
                }

            }
        }
    }
}