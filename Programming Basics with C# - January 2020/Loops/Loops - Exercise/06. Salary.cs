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
            for (int loop = 1; loop <= tabs; loop++)
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
                if (loop == tabs)
                {
                    Console.WriteLine(salary);
                    break;
                }
            }
        }
    }
}
