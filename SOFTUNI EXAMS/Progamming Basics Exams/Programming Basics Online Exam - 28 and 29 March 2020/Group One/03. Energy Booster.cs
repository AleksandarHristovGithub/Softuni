using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Energy_Booster
{

    public class Program
    {


        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string sizeOfSet = Console.ReadLine();
            double numberOfOrderedSets = double.Parse(Console.ReadLine());

            if (fruit == "Watermelon")
            {
                if (sizeOfSet == "small")
                {
                    double bigPacketWatermelon = 2 * 56;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
                else if (sizeOfSet == "big")
                {
                    double bigPacketWatermelon = 5 * 28.70;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
            }
            if (fruit == "Mango")
            {
                if (sizeOfSet == "small")
                {
                    double bigPacketWatermelon = 2 * 36.66;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
                else if (sizeOfSet == "big")
                {
                    double bigPacketWatermelon = 5 * 19.60;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
            }
            if (fruit == "Pineapple")
            {
                if (sizeOfSet == "small")
                {
                    double bigPacketWatermelon = 2 * 42.10;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
                else if (sizeOfSet == "big")
                {
                    double bigPacketWatermelon = 5 * 24.80;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
            }
            if (fruit == "Raspberry")
            {
                if (sizeOfSet == "small")
                {
                    double bigPacketWatermelon = 2 * 20;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
                else if (sizeOfSet == "big")
                {
                    double bigPacketWatermelon = 5 * 15.20;
                    double priceOfSet = numberOfOrderedSets * bigPacketWatermelon;
                    if (priceOfSet < 400)
                    {
                        Console.WriteLine($"{priceOfSet:F2} lv.");
                    }
                    else if (priceOfSet >= 400 && priceOfSet <= 1000)
                    {

                        double FifteenPercentDiscount = priceOfSet - (priceOfSet * 0.15);
                        Console.WriteLine($"{FifteenPercentDiscount:F2} lv.");
                    }
                    else if (priceOfSet > 1000)
                    {
                        double FiftyPercentDiscount = priceOfSet - (priceOfSet * 0.50);
                        Console.WriteLine($"{FiftyPercentDiscount:F2} lv.");
                    }
                }
            }
        }
    }
}
