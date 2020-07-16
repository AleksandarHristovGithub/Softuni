using System;

namespace Foreign_Languages


{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            if (country == "USA")
            {
                Console.WriteLine("English");
            }
            if (country == "England")
            {
                Console.WriteLine("English");
            }
            if (country == "Spain")
            {
                Console.WriteLine("Spanish");
            }
            if (country == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            if (country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else if (country != "Mexico" && country != "Argentina" && country != "Spain" && country != "England" && country != "USA")
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
