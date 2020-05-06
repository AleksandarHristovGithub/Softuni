using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double cakeFirst = double.Parse(Console.ReadLine());
            double cakeSecond = double.Parse(Console.ReadLine());
            BIRD:
            string command = Console.ReadLine();


            for (int i = 1; i <= 100; i++)
            {

                if (total <= cakeFirst * cakeSecond && command != "STOP")
                {

                    double steps = double.Parse(command);
                    total += steps;

                    if (total >= cakeFirst * cakeSecond)
                    {
                        Console.WriteLine($"No more cake left! You need {total - cakeFirst * cakeSecond} pieces more.");
                        break;
                    }

                    goto BIRD;

                }
                else if (command == "STOP")
                {
                    Console.WriteLine($"{cakeFirst * cakeSecond - total} pieces are left.");
                    break;
                }
            }
        }
    }
}
