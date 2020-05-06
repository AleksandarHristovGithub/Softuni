using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            BIRD:
            string command = Console.ReadLine();


            for (int i = 1; i <= 100; i++)
            {
                if (total < 10000 && command != "Going home")
                {

                    double steps = double.Parse(command);
                    total += steps;

                    if (total >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }

                    goto BIRD;

                }
                else if (command == "Going home")
                {
                    string commandHome = Console.ReadLine();
                    int steps = int.Parse(commandHome);
                    total += steps;
                    if (total >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{10000 - total} more steps to reach goal.");
                        break;
                    }
                }
            }
        }
    }
}
