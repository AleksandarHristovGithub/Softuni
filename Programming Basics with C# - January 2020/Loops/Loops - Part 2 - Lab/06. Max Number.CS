using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Min_Number


{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);

            }
            Console.WriteLine(numbers.Min());
        }

    }
}