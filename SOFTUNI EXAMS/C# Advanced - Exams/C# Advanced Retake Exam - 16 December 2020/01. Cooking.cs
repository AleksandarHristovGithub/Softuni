using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{

    class Program
    {

        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> items = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));



            Stack<int> rev = new Stack<int>();
            int bread = 0;
            int cake = 0;
            int fruitPie = 0;
            int pastry = 0;



            Dictionary<string, int> madeItems = new Dictionary<string, int>
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Fruit Pie", 0 },
                {"Pastry", 0 }
            };

            while (items.Count > 0 && liquids.Count > 0)
            {
                int currItem = items.Pop();
                switch (liquids.Dequeue() + currItem)
                {
                    case 25:
                        madeItems["Bread"]++;
                        break;
                    case 50:
                        madeItems["Cake"]++;
                        break;
                    case 75:
                        madeItems["Pastry"]++;
                        break;
                    case 100:
                        madeItems["Fruit Pie"]++;
                        break;
                    default:
                        items.Push(currItem + 3);
                        break;
                }
            }


            if (!madeItems.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            if (madeItems.ContainsValue(0))
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", items)}");
            }

            foreach (var item in madeItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

    }
}