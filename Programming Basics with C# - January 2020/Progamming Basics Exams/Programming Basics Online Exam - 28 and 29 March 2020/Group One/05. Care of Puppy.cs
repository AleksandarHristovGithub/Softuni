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

namespace Care_Of_Puppy
{

    public class Program
    {


        static void Main(string[] args)
        {
            double foodKG = double.Parse(Console.ReadLine());
            double foodInGrams = foodKG * 1000;
            double totalFood = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Adopted")
                {
                    if (foodInGrams >= totalFood)
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {Math.Abs(totalFood - foodInGrams)} grams.");
                        break;
                    }
                    else if (foodInGrams < totalFood)
                    {
                        Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGrams - totalFood)} grams more.");
                        break;
                    }
                }
                else
                {
                    int food = int.Parse(command);
                    totalFood += food;
                }
            }
        }
    }
}
