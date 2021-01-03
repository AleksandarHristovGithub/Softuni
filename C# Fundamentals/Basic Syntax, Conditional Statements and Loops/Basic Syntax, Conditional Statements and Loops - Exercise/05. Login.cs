using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;

namespace Login




{
    public class Startup
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string reversedString = new string(username.Reverse().ToArray());
            int counter = 0;
            while (true)
            {
                string password = Console.ReadLine();
                counter++;
                if (counter == 4 && reversedString != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (reversedString != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    continue;
                }
                else if (reversedString == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
