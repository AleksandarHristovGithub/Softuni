using System;
using System.Collections.Generic;
using System.Linq;

namespace Login



{
    class Program
    {

        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int maxTries = 0;

            char[] array = username.ToCharArray();
            Array.Reverse(array);
            string reversedName = string.Concat(array);
            while (maxTries < 4)
            {
                string usernameToTry = Console.ReadLine();
                maxTries++;
                if (usernameToTry != reversedName && maxTries != 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                if (usernameToTry == reversedName)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (maxTries == 4)
                {
                    Console.WriteLine($"User {username} blocked!");

                }
            }
        }
    }
}