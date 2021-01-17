using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Change_Bureau
{

    public class Program
    {


        static void Main(string[] args)
        {
            double numberOfBitcoin = double.Parse(Console.ReadLine());
            double chineseYuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double bitcoinToLV = numberOfBitcoin * 1168;
            double yuanToUSD = chineseYuan * 0.15;
            double USDToBGN = yuanToUSD * 1.76;

            double toEuro = (bitcoinToLV + USDToBGN) / 1.95;
            double commisionBGN = toEuro - (toEuro * (commision / 100));
            Console.WriteLine($"{commisionBGN:F2}");
        }
    }
}
