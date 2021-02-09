using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<int> firstLootBox = new Queue<int>
        (Console.ReadLine()
             .Split(" ")
             .Select(int.Parse)
             .ToList());




            Queue<int> secondLootBox = new Queue<int>
                (Console.ReadLine()
                .Split(" ")
             .Select(int.Parse)
             .Reverse()
             .ToList());

            List<int> claimedItems = new List<int>();
            while (true)
            {
                if (firstLootBox.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    if (claimedItems.Sum() >= 100)
                    {
                        Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
                    }
                    else if (claimedItems.Sum() < 100)
                    {
                        Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
                    }
                    break;
                }
                if (secondLootBox.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    if (claimedItems.Sum() >= 100)
                    {
                        Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
                    }
                    else if (claimedItems.Sum() < 100)
                    {
                        Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
                    }
                    break;
                }
                int firstLootBoxPeek = firstLootBox.Peek();
                int secondLootBoxPeek = secondLootBox.Peek();

                int evenOrNot = firstLootBoxPeek + secondLootBoxPeek;
                if (evenOrNot % 2 == 0)
                {
                    firstLootBox.Dequeue();
                    secondLootBox.Dequeue();
                    claimedItems.Add(evenOrNot);
                }

                else
                {
                    firstLootBox.Enqueue(secondLootBoxPeek);
                    secondLootBox.Dequeue();
                }


            }
        }
    }
}