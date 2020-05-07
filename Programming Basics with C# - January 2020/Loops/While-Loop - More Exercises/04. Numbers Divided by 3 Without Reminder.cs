using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Numbers_Divided_by_three_Without_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}