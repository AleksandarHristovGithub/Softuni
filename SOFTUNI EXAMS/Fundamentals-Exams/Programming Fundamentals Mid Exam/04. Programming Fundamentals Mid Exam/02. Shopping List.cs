using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new List<string>(Console.ReadLine().Split("!"));



            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {

                string[] tokens = command.Split(" ").ToArray();
                string subCommand = tokens[0];
                string item = tokens[1];

                if (subCommand == "Urgent")
                {
                    if (shoppingList.Contains(item))
                    {

                    }
                    else
                    {
                        shoppingList.Insert(0, item);

                    }

                }
                if (subCommand == "Unnecessary")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.RemoveAll(p => p == item);
                    }
                    else
                    {

                    }
                }
                if (subCommand == "Rearrange")
                {
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                    else
                    {

                    }
                }


                if (subCommand == "Correct")
                {

                    string oldItem = tokens[1];
                    string newItem = tokens[2];
                    if (shoppingList.Contains(oldItem))
                    {

                        shoppingList[shoppingList.FindIndex(ind => ind.Equals(oldItem))] = newItem;
                    }
                    else
                    {
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
