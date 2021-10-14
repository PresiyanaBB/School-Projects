using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    interface ISmetki
    {
        public double MesLihva(double lihpro,int klient,int meseci);
        public static void Balansirane()
        {
            if(OutKlient.balancee.Count == 2)
            {
                OutKlient.balancee[1] = OutKlient.balancee[1] - OutKlient.balancee[0];
            }
        }
    }
}
