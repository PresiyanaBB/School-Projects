using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface OutKlient
    {
        public static List<double> balancee = new List<double>();
        public static int k;
        public static int zero = 0;
        public static void DaliKlient()
        {
            Console.Write("1-физ.лице  2-фирма   :");
            k = int.Parse(Console.ReadLine());
            Smetki.Klient(k);
        }
    }
}
