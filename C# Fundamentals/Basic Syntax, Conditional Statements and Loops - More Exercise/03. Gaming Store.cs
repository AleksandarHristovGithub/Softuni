using System;
using System.Linq;
class GamingStore
{
    public static void Main()
    {
        double OutFall4 = 39.99;
        double CSOG = 15.99;
        double ZplinterCell = 19.99;
        double Honored2 = 59.99;
        double RoverWatch = 29.99;
        double RoverWatchOriginsEdition = 39.99;

        double balance = double.Parse(Console.ReadLine());
        double sumOfAllGames = 0;

        for (int i = 0; i < 10; i++)
        {
            string command = Console.ReadLine();
            if (balance == 0 && command == "Game Time")
            {
                Console.WriteLine("Out of money");
                break;
            }
            else if (command == "Game Time")
            {

                Console.WriteLine($"Total spent: ${sumOfAllGames:F2}. Remaining: ${balance:F2}");
                break;

            }
            else if (command != "OutFall 4" && command != "CS: OG" && command != "Zplinter Zell" && command != "Honored 2" && command != "RoverWatch" && command != "RoverWatch Origins Edition" && command != "Game Time")
            {
                Console.WriteLine("Not Found");
            }
            else if (command == "OutFall 4" && balance >= OutFall4)
            {
                sumOfAllGames += OutFall4;
                balance -= OutFall4;
                Console.WriteLine("Bought OutFall 4");
            }
            else if (command == "CS: OG" && balance >= CSOG)
            {
                sumOfAllGames += CSOG;
                balance -= CSOG;
                Console.WriteLine("Bought CS: OG");
            }
            else if (command == "Zplinter Zell" && balance >= ZplinterCell)
            {
                sumOfAllGames += ZplinterCell;
                balance -= ZplinterCell;
                Console.WriteLine("Bought Zplinter Zell");
            }
            else if (command == "Honored 2" && balance >= Honored2)
            {
                sumOfAllGames += Honored2;
                balance -= Honored2;
                Console.WriteLine("Bought Honored 2");
            }
            else if (command == "RoverWatch" && balance >= RoverWatch)
            {
                sumOfAllGames += RoverWatch;
                balance -= RoverWatch;
                Console.WriteLine("Bought RoverWatch");
            }
            else if (command == "RoverWatch Origins Edition" && balance >= RoverWatchOriginsEdition)
            {
                sumOfAllGames += RoverWatchOriginsEdition;
                balance -= RoverWatchOriginsEdition;
                Console.WriteLine("Bought RoverWatch Origins Edition");
            }
            else if (balance < OutFall4)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (balance < CSOG)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (balance < ZplinterCell)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (balance < Honored2)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (balance < RoverWatch)
            {
                Console.WriteLine("Too Expensive");
            }
            else if (balance < RoverWatchOriginsEdition)
            {
                Console.WriteLine("Too Expensive");
            }





        }
    }
}

