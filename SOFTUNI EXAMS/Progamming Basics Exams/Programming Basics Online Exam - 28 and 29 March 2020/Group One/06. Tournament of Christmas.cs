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

namespace Tournament_Of_Christmas
{

    public class Program
    {


        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double leftdays = (days - days);
            double totalWins = 1;
            double totalLoses = 1;
            double wins = 0;
            double loses = 0;
            double finalMoney = 0;
            double money = 0;
            for (double i = leftdays; i <= days;)
            {


                string sport = Console.ReadLine();


                if (sport == "win")
                {
                    totalWins++;
                    wins++;
                }
                if (sport == "lose")
                {
                    totalLoses++;
                    loses++;
                }

                if (sport == "Finish" && wins > loses)
                {

                    double moreMoney = wins * 20;
                    double moreMoneyAdd = moreMoney + (moreMoney * 0.10);
                    finalMoney += moreMoneyAdd;
                    wins -= wins;
                    loses -= loses;

                    i++;
                }
                if (sport == "Finish" && wins < loses)
                {
                    double moreMoney = wins * 20;

                    finalMoney += moreMoney;
                    wins -= wins;
                    loses -= loses;

                    i++;

                }
                if (i == days && totalLoses > totalWins)
                {

                    Console.WriteLine($"You lost the tournament! Total raised money: {finalMoney:F2}");

                    break;
                }
                if (i == days && totalWins > totalLoses)
                {

                    finalMoney += finalMoney * 0.20;
                    Console.WriteLine($"You won the tournament! Total raised money: {finalMoney:F2}");

                    break;
                }

            }


        }
    }
}
