using System;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Diagnostics.Tracing;
using System.Collections.Generic;

namespace SortNumbers




{
    public class Startup
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            List<int> mylist = new List<int>();
            mylist.Add(num1);
            mylist.Add(num2);
            mylist.Add(num3);
            mylist.Sort();
            mylist.Reverse();
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}