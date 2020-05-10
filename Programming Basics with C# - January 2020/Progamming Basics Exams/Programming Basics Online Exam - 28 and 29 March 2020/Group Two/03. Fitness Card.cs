using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fitness_Card
{

    public class Program
    {


        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            if (gender == "m")
            {
                if (sport == "Gym")
                {
                    if (age > 19)
                    {

                        if (sum > 42)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${42 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 42 - (42 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Boxing")
                {
                    if (age > 19)
                    {

                        if (sum > 41)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${41 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 41 - (41 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Yoga")
                {
                    if (age > 19)
                    {

                        if (sum > 45)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${45 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 45 - (45 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Zumba")
                {
                    if (age > 19)
                    {

                        if (sum > 34)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${34 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 34 - (34 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Dances")
                {
                    if (age > 19)
                    {

                        if (sum > 51)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${51 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 51 - (51 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Pilates")
                {
                    if (age > 19)
                    {

                        if (sum > 39)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${39 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 39 - (39 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
            }
            if (gender == "f")
            {
                if (sport == "Gym")
                {
                    if (age > 19)
                    {

                        if (sum > 35)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${35 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 35 - (35 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Boxing")
                {
                    if (age > 19)
                    {

                        if (sum > 37)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${37 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 37 - (37 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Yoga")
                {
                    if (age > 19)
                    {

                        if (sum > 42)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${42 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 42 - (42 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Zumba")
                {
                    if (age > 19)
                    {

                        if (sum > 31)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${31 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 31 - (31 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Dances")
                {
                    if (age > 19)
                    {

                        if (sum > 53)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${53 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 53 - (53 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
                if (sport == "Pilates")
                {
                    if (age > 19)
                    {

                        if (sum > 37)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${37 - sum:F2} more.");
                        }
                    }
                    else
                    {
                        double discount = 37 - (37 * 0.20);
                        if (sum > discount)
                        {
                            Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                        }
                        else
                        {
                            Console.WriteLine($"You don't have enough money! You need ${discount - sum:F2} more.");
                        }
                    }

                }
            }
        }
    }
}