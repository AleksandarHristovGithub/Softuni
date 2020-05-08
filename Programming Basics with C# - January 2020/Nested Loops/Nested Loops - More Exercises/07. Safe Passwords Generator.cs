using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Safe_Password_Generator
{

    public class Program
    {


        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());


            char A = (char)35;
            char B = (char)64;
            int br = 1;
            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    br++;

                    Console.Write($"{A}{B}{x}{y}{B}{A}|");
                    A++;
                    B++;
                    if (A > 55)
                    {
                        A = (char)35;
                    }
                    if (B > 96)
                    {
                        B = (char)64;
                    }
                    if (br > maxPasswords)
                    {
                        return;
                    }
                }
            }
        }
    }
}