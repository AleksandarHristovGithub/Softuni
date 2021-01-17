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

namespace Food_For_Pets
{

    public class Program
    {


        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());
            double i = 0;

            while (days >= i + 1)
            {



                double catEatenFood = 0;
                double dogEatenFood = 0;

                double catThirdDay = 0;
                double dogThirdDay = 0;
                double biscuits = 0;


                Food:
                double eatDog = double.Parse(Console.ReadLine());
                double eatCat = double.Parse(Console.ReadLine());

                if (days >= i && days != i)
                {
                    dogEatenFood += eatDog;
                    catEatenFood += eatCat;
                    i++;
                    if (i % 3 == 0)
                    {
                        biscuits += (eatDog + eatCat) / 10;
                    }
                    if (i == days)
                    {
                        goto final;
                    }
                    goto Food;
                }

                final:
                Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits)}gr.");
                Console.WriteLine($"{((catEatenFood + dogEatenFood) / totalFood) * 100:F2}% of the food has been eaten.");
                Console.WriteLine($"{(dogEatenFood / (dogEatenFood + catEatenFood)) * 100:F2}% eaten from the dog.");
                Console.WriteLine($"{(catEatenFood / (dogEatenFood + catEatenFood)) * 100:F2}% eaten from the cat.");




            }
        }
    }
}