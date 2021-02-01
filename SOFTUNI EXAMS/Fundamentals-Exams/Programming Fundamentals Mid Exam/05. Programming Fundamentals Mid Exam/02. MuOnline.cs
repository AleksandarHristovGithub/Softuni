using System;
using System.Collections.Generic;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine().Split('|');

            int health = 100;
            int currHealth = 0;
            int tempHealth = 0;
            int bitcoins = 0;
            int bestRoom = 0;

            bool notDead = true;
            for (int i = 0; i < rooms.Length; i++)
            {

                string command = rooms[i];
                string[] splitted = command.Split();

                if (splitted[0] == "potion")
                {
                    tempHealth = health;
                    currHealth = health;
                    currHealth += int.Parse(splitted[1]);
                    if (currHealth <= 100)
                    {
                        health += int.Parse(splitted[1]);
                        Console.WriteLine($"You healed for {splitted[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                    else if (currHealth > 100)
                    {
                        int diff = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {diff} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    bestRoom++;
                }
                else if (splitted[0] == "chest")
                {
                    int bitcoinsToAdd = int.Parse(splitted[1]);
                    bitcoins += bitcoinsToAdd;
                    Console.WriteLine($"You found {bitcoinsToAdd} bitcoins.");
                    bestRoom++;
                }
                else
                {
                    int monsterAttack = int.Parse(splitted[1]);

                    if (health > monsterAttack)
                    {
                        Console.WriteLine($"You slayed {splitted[0]}.");
                        health -= monsterAttack;
                        bestRoom++;
                    }
                    else if (health <= monsterAttack)
                    {
                        bestRoom++;
                        Console.WriteLine($"You died! Killed by {splitted[0]}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        notDead = false;
                        break;
                    }

                }
            }
            if (notDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}