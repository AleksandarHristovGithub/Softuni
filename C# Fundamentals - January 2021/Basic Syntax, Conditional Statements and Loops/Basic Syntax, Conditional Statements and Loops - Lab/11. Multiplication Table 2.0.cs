using System;
using System.Linq;
using System.Text;

namespace MultiplicationTableV2



{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int numberForMultiplication = int.Parse(Console.ReadLine());
            int timesForMultiplication = int.Parse(Console.ReadLine());
            if (timesForMultiplication > 10)
            {
                Console.WriteLine($"{numberForMultiplication} X {timesForMultiplication} = {numberForMultiplication * timesForMultiplication}");

            }
            for (int i = timesForMultiplication; i <= 10; i++)
            {


                Console.WriteLine($"{numberForMultiplication} X {i} = {numberForMultiplication * i}");

            }
        }
    }
}