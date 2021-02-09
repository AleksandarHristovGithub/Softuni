using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>
                 (Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse));




            Stack<int> bombcasings = new Stack<int>
                (Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;

            while (bombEffects.Count > 0 && bombcasings.Count > 0)
            {
                int bombEffectsPeek = bombEffects.Peek();
                int bombcasingsPeek = bombcasings.Peek();
                int sumOfBoth = bombcasingsPeek + bombEffectsPeek;
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    break;
                }
                if (sumOfBoth == 40)
                {


                    daturaBombs++;
                    bombcasings.Pop();
                    bombEffects.Dequeue();
                    continue;
                }
                if (sumOfBoth == 60)
                {


                    cherryBombs++;
                    bombcasings.Pop();
                    bombEffects.Dequeue();
                    continue;
                }
                if (sumOfBoth == 120)
                {


                    smokeDecoyBombs++;
                    bombcasings.Pop();
                    bombEffects.Dequeue();
                    continue;
                }
                else
                {
                    bombcasings.Pop();
                    int minusFive = bombcasingsPeek - 5;
                    bombcasings.Push(minusFive);
                    continue;
                }
            }

            if (bombEffects.Count == 0 && bombcasings.Count == 0 && daturaBombs != 3 && cherryBombs != 3 && smokeDecoyBombs != 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                Console.WriteLine("Bomb Effects: " + "empty");
                Console.WriteLine("Bomb Casings: " + "empty");
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count > 0 && bombcasings.Count == 0 && daturaBombs != 3 && cherryBombs != 3 && smokeDecoyBombs != 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects).ToString());
                Console.WriteLine("Bomb Casings: " + "empty");
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count == 0 && bombcasings.Count > 0 && daturaBombs != 3 && cherryBombs != 3 && smokeDecoyBombs != 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                Console.WriteLine("Bomb Effects: " + "empty");
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombcasings).ToString());
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count > 0 && bombcasings.Count > 0 && daturaBombs != 3 && cherryBombs != 3 && smokeDecoyBombs != 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects).ToString());
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombcasings).ToString());
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count == 0 && bombcasings.Count == 0 && daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                Console.WriteLine("Bomb Effects: " + "empty");
                Console.WriteLine("Bomb Casings: " + "empty");
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count > 0 && bombcasings.Count == 0 && daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects).ToString());
                Console.WriteLine("Bomb Casings: " + "empty");
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count == 0 && bombcasings.Count > 0 && daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                Console.WriteLine("Bomb Effects: " + "empty");
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombcasings).ToString());
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
            if (bombEffects.Count > 0 && bombcasings.Count > 0 && daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                Console.WriteLine("Bomb Effects: " + string.Join(", ", bombEffects).ToString());
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombcasings).ToString());
                Console.WriteLine("Cherry Bombs: " + cherryBombs);
                Console.WriteLine("Datura Bombs: " + daturaBombs);
                Console.WriteLine("Smoke Decoy Bombs: " + smokeDecoyBombs);
            }
        }
    }
}
