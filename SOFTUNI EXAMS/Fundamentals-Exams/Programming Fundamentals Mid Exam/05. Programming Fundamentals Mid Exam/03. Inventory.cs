using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new List<string>(Console.ReadLine().Split(", "));



            string command = Console.ReadLine();

            while (command != "Craft!")
            {

                string[] tokens = command.Split(" - ").ToArray();
                string subCommand = tokens[0];
                string item = tokens[1];

                if (subCommand == "Collect")
                {
                    if (inventory.Contains(item))
                    {

                    }
                    else
                    {
                        inventory.Add(item);

                    }

                }
                if (subCommand == "Drop")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                    }
                    else
                    {

                    }
                }
                if (subCommand == "Renew")
                {
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                    else
                    {

                    }
                }
                if (subCommand == "Combine Items")
                {
                    string[] tokensForCombine = item.Split(':').ToArray();
                    string oldItem = tokensForCombine[0];
                    string newItem = tokensForCombine[1];
                    if (inventory.Contains(oldItem))
                    {
                        int index = inventory.IndexOf(oldItem);
                        inventory.Insert(index + 1, newItem);
                    }
                    else
                    {
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}

