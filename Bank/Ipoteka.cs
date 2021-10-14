using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Ipoteka: Smetki, ISmetki
    {
        public double MesLihva(double lihpro,int klient,int meseci)
        {
            if(klient==1)
            {
                if (meseci > 6) return (meseci - 6) * lihpro/100;
                else return 0;
            }
            else
            {
                if (meseci <= 12) return (meseci * lihpro) / 200;
                else return ((meseci * lihpro) - (12 * lihpro)) / 200;
            }
        }
    }
}
