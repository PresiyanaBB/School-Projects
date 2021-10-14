using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Depozit : Smetki, ISmetki
    {
        public double MesLihva(double lihpro,int klient,int meseci)
        {
            if (balance > 0 && balance < 1000) return 0;
            else return meseci * lihpro/100;
        }
    }
}
