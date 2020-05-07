using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            double washingAgent = double.Parse(Console.ReadLine());
            double washingAgentMl = 750 * washingAgent;
            double counter = 1;
            double dishesTotal = 0;
            double potsTotal = 0;
            double washingAgentTotal = 0;
            test:
            string command = Console.ReadLine();

            while (command != "End")
            {
                if (counter % 3 == 0)
                {
                    double pots = double.Parse(command);
                    washingAgentMl -= pots * 15;

                    potsTotal += pots;

                    counter++;
                    if (washingAgentTotal > washingAgentMl)
                    {

                        Console.WriteLine($"Not enough detergent, {washingAgentTotal - washingAgentMl} ml. more necessary!");
                        break;
                    }
                    goto test;

                }
                if (counter % 1 == 0 && counter % 3 != 0)
                {
                    double dishes = int.Parse(command);
                    washingAgentMl -= dishes * 5;

                    dishesTotal += dishes;

                    counter++;
                    if (washingAgentTotal > washingAgentMl)
                    {

                        Console.WriteLine($"Not enough detergent, {washingAgentTotal - washingAgentMl} ml. more necessary!");
                        break;
                    }
                    goto test;

                }


                if (counter % 2 == 0 && counter % 6 != 0)
                {
                    double dishes = int.Parse(command);
                    washingAgentMl -= dishes * 5;

                    dishesTotal += dishes;

                    counter++;
                    if (washingAgentTotal > washingAgentMl)
                    {

                        Console.WriteLine($"Not enough detergent, {washingAgentTotal - washingAgentMl} ml. more necessary!");
                        break;
                    }
                    goto test;

                }
                washingAgentTotal += dishesTotal * 5;
                washingAgentTotal += potsTotal * 15;
            }
            if (command == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesTotal} dishes and {potsTotal} pots were washed.");
                Console.WriteLine($"Leftover detergent {washingAgentMl} ml.");
            }

        }
    }
}