using System;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Ages




{
    public class Startup
    {
        public static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            if (age <= 2)
            {
                Console.WriteLine("baby");
            }
            if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            if (age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
