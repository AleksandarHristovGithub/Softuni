using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Suitcases_Load
{

    public class Program
    {


        static void Main(string[] args)
        {
            double capacityOfStorage = double.Parse(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    Console.WriteLine($"Statistic: {i - 1} suitcases loaded.");
                    break;
                }
                if (i % 3 == 0)
                {
                    double suitCase = double.Parse(command);
                    suitCase += suitCase * 0.10;
                    capacityOfStorage -= suitCase;
                    if (capacityOfStorage <= 0)
                    {
                        Console.WriteLine($"No more space!");
                        Console.WriteLine($"Statistic: {i - 1} suitcases loaded.");
                        break;
                    }
                }
                else
                {
                    double suitCase = double.Parse(command);
                    capacityOfStorage -= suitCase;
                    if (capacityOfStorage <= 0)
                    {
                        Console.WriteLine($"No more space!");
                        Console.WriteLine($"Statistic: {i - 1} suitcases loaded.");
                        break;
                    }
                }

            }
        }
    }
}