using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

namespace GamingStore




{
    public class Startup
    {
        static void Main(string[] args)
        {
            double OutFall4 = 39.99;
            double CSOG = 15.99;
            double ZplinterCell = 19.99;
            double Honored2 = 59.99;
            double RoverWatch = 29.99;
            double RoverWatchOriginsEdition = 39.99;
            double totalSpent = 0;
            double balance = double.Parse(Console.ReadLine());
            while (true)
            {
                string command = Console.ReadLine();
                if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2" && command != "RoverWatch" && command != "RoverWatch Origins Edition" && command != "Game Time")
                {
                    Console.WriteLine("Not Found");
                    continue;
                }
                else if (command == "Game Time" && balance > 0)
                {
                    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
                    break;
                }
                else if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                else if (balance < OutFall4 && command == "OutFall 4" || balance < CSOG && command == "CS: OG" || balance < ZplinterCell && command == "Zplinter Zell" || balance < Honored2 && command == "Honored 2" || balance < RoverWatch && command == "RoverWatch" || balance < RoverWatchOriginsEdition && command == "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                else if (balance > OutFall4 || balance > CSOG || balance > ZplinterCell || balance > Honored2 || balance > RoverWatch || balance > RoverWatchOriginsEdition)
                {
                    Console.WriteLine($"Bought {command}");
                    if (command == "OutFall 4")
                    {
                        totalSpent += OutFall4;
                        balance -= OutFall4;
                    }
                    else if (command == "CS: OG")
                    {
                        totalSpent += CSOG;
                        balance -= CSOG;
                    }
                    else if (command == "Zplinter Zell")
                    {
                        totalSpent += ZplinterCell;
                        balance -= ZplinterCell;
                    }
                    else if (command == "Honored 2")
                    {
                        totalSpent += Honored2;
                        balance -= Honored2;
                    }
                    else if (command == "RoverWatch")
                    {
                        totalSpent += RoverWatch;
                        balance -= RoverWatch;
                    }
                    else if (command == "RoverWatch Origins Edition")
                    {
                        totalSpent += RoverWatchOriginsEdition;
                        balance -= RoverWatchOriginsEdition;
                    }
                    continue;
                }


            }
        }
    }
}