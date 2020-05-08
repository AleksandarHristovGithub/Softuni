using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unique_PIN_Codes
{

    public class Program
    {
        public static void Main()

        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            for (int i = 2; i <= first; i += 2)
            {
                for (int j = 2; j <= second; j++)
                {
                    for (int k = 2; k <= third; k += 2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            Console.WriteLine(i + " " + j + " " + k);
                        }
                    }
                }
            }
        }
    }
}