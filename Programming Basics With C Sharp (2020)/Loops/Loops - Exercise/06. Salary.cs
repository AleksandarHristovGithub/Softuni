using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary


{
    class Program
    {
        static void Main(string[] args)
        {
            double tabs = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            for (int i = 1; i <= tabs; i++)
            {
                string website = Console.ReadLine();
                if (website == "Facebook")
                {
                    salary -= 150;
                }
                if (website == "Instagram")
                {
                    salary -= 100;
                }
                if (website == "Reddit")
                {
                    salary -= 50;
                }
                if (salary == 0)
                {


                    Console.WriteLine("You have lost your salary.");
                    break;


                }
                if (i == tabs)
                {
                    Console.WriteLine(salary);
                    break;
                }
            }
        }
    }
}
