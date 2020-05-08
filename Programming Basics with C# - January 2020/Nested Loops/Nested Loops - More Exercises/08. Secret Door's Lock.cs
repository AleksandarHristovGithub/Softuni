using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Secret_Doors_Lock
{

    public class Program
    {


        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            for (int i = 1; i < a + 1; i++)
            {
                if (i % 2 == 0)
                {

                    for (int j = 0; j < b + 1; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {

                            for (int k = 1; k < c + 1; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}