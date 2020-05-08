using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Letter_Combinations
{

    public class Program
    {


        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();
            string result = "";
            var counter = 0;

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        result = $"{i}{j}{k}";
                        if (!result.Contains(skip))
                        {
                            Console.Write(result + " ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}