using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;
using System.Numerics;

namespace TripleOfLatinLetters





{
    public class Startup
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());


            for (char i = 'a'; i < 'a' + number; i++)
            {

                for (char k = 'a'; k < 'a' + number; k++)
                {


                    for (char l = 'a'; l < 'a' + number; l++)
                    {


                        Console.WriteLine($"{i}{k}{l}");
                    }

                }

            }
        }
    }
}