namespace Number_Pyramid
{
    using System;
    using System.Data.SqlTypes;
    using System.IO;
    using System.Security.Cryptography;

    class program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curret = 1;
            bool isBigger = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (curret > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(curret + " ");
                    curret++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
