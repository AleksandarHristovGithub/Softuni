using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FashionBotique

{
    class Program
    {
        static void Main(string[] args)
        {

            var priceOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfARack = int.Parse(Console.ReadLine());

            Stack<int> prices = new Stack<int>(priceOfClothes);

            int sumOfClothes = 0;
            int numOfRacks = 1;

           

            for (int i = priceOfClothes.Length - 1; i >= 0; i--)
            {
                sumOfClothes += priceOfClothes[i];

                if (sumOfClothes <= capacityOfARack)
                {
                    if (prices.Any())
                    {
                        prices.Pop();
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    i++;
                    numOfRacks++;
                    sumOfClothes = 0;
                }
            }

            Console.WriteLine(numOfRacks);
        }
    }
}