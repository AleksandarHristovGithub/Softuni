namespace Travelling
{
    using System;
    using System.Data.SqlTypes;
    using System.IO;
    using System.Security.Cryptography;

    class program
    {

        static void Main(string[] args)
        {
            Destination:
            double money = 0;
            string destination = Console.ReadLine();

            while (destination != "End")
            {

                double minimumBudget = double.Parse(Console.ReadLine());
                Money:

                double moneyCollection = double.Parse(Console.ReadLine());
                money += moneyCollection;
                if (minimumBudget > money)
                {


                    goto Money;
                }
                if (money >= minimumBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    if (destination == "End")
                    {
                        break;
                    }
                    goto Destination;
                }
                if (destination == "End")
                {
                    break;


                }

            }
        }
    }
}
