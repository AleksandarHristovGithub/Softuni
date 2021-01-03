using System;
using System.Linq;
using System.Text;

namespace EvenNumber



{
    public class Startup
    {
        public static void Main(string[] args)
        {
            EvenNumber:
            int evenNumber = int.Parse(Console.ReadLine());
            while (evenNumber % 2 != 0)
            {

                Console.WriteLine("Please write an even number.");


                goto EvenNumber;
            }
            if (evenNumber % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(evenNumber)}");

            }
        }
    }
}
