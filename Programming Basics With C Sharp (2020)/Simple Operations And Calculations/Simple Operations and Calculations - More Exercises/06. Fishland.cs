using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfSkumriq = double.Parse(Console.ReadLine());
            double priceOfCacaKg = double.Parse(Console.ReadLine());
            double priceOfPalmudKG = double.Parse(Console.ReadLine());
            double priceOfSafridKG = double.Parse(Console.ReadLine());
            double priceOfMidiKG = double.Parse(Console.ReadLine());

            double pricePalmud = priceOfSkumriq + priceOfSkumriq * 0.60;
            double sumPalmud = priceOfPalmudKG * pricePalmud;
            double priceSafrid = priceOfCacaKg + priceOfCacaKg * 0.80;
            double sumSafrid = priceOfSafridKG * priceSafrid;
            double sumMidi = priceOfMidiKG * 7.50;
            double total = sumMidi + sumSafrid + sumPalmud;
            Console.WriteLine($"{total:F2}");
        }
    }
}
