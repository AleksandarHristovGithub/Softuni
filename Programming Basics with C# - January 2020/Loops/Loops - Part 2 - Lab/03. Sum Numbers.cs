using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers


{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command != "Stop")
                {
                    int sum = Convert.ToInt32(command);
                    total += sum;
                }
                if (command == "Stop")
                {
                    Console.WriteLine(total);
                    break;
                }
            }

        }
    }
}