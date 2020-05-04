using System;
using System.Collections;
using System.Text;
using System.Linq;
namespace Flowers









{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = Console.ReadLine();
            double hrprice = 0, roprice = 0, laprice = 0;
            if (season == "Spring" || season == "Summer")
            {
                hrprice = 2 * hrizantemi;
                roprice = 4.1 * rozi;
                laprice = 2.5 * laleta;
            }
            if (season == "Autumn" || season == "Winter")
            {
                hrprice = 3.75 * hrizantemi;
                roprice = 4.5 * rozi;
                laprice = 4.15 * laleta;
            }
            double totalprice = hrprice + roprice + laprice;
            
            if (laleta > 7 && season == "Spring")
            {
                totalprice *= 0.95;
            }
            if ((rozi >= 10) && (season == "Winter"))
            {
                totalprice *= 0.90;
            }
            if (holiday == "Y")
            {
                totalprice *= 1.15;
            }
            if (rozi + laleta + hrizantemi >= 20)
            {
                totalprice *= 0.80;
            }
            Console.WriteLine(string.Format("{0:f2}", totalprice + 2));
            Console.ReadLine();
        }
    }
}
