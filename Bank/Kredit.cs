using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Kredit: Smetki, ISmetki
    {
        public double MesLihva(double lihpro,int klient,int meseci)
        {
            if (klient == 1)
            {
                if (meseci > 3) return (meseci - 3) * lihpro/100;
                else return 0;
            }
            else
            {
                if (meseci > 2) return (meseci - 2) * lihpro/100;
                else return 0;
            }
        }
    }
}
