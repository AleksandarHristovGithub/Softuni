using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TrafficJam

{
    class Program
    {
        static void Main(string[] args)
        {

            int throughput = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < throughput; i++)
                    {
                        if (queue.Count > 0)
                        {


                            var car = queue.Dequeue();
                            count++;
                            Console.WriteLine(car + " passed!");
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine(count + " cars passed the crossroads.");
        }
    }
}

