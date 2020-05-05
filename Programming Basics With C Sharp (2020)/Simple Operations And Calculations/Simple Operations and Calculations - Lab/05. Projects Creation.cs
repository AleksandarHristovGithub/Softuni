using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArhitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            int timeForProject = numberOfProjects * 3;
            Console.WriteLine($"The architect {nameOfArhitect} will need {timeForProject} hours to complete {numberOfProjects} project/s.");
        }
    }
}
