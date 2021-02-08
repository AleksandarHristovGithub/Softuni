using System;
using System.Linq;
using System.Text;

namespace MultiplicationTable



{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int numberForMultiplication = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numberForMultiplication} X {i} = {numberForMultiplication * i}");
            }
        }
    }
}