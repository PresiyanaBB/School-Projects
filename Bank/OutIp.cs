using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface OutIp:OutKlient,Input
    {
        public static void OutIpoteka()
        {
            Ipoteka dep = new Ipoteka();
            Console.Write("1-внасяне 2-лихвата    :");
            int w = int.Parse(Console.ReadLine());
            switch (w)
            {
                case 1:
                    {
                        Input.InputAll();
                        Smetki.Vnasqne(int.Parse(Console.ReadLine()));
                        Console.WriteLine("балансът е {0:F2}лв ", OutKlient.balancee[Smetki.vs.IndexOf(Smetki.cperson)] - dep.MesLihva(Smetki.lihpro, k, mesec));
                        balancee.Add(OutKlient.balancee[Smetki.vs.IndexOf(Smetki.cperson)] - dep.MesLihva(Smetki.lihpro, k, mesec));
                        ISmetki.Balansirane();
                        break;
                    }
                case 2:
                    {
                        Console.Write("бр месеци: ");
                        int mesec = int.Parse(Console.ReadLine());
                        Console.WriteLine("лихвен % = {0}  , месечна лихва: {1:F2}  ", Ipoteka.lihpro, dep.MesLihva(Smetki.lihpro, k, mesec));
                        Console.ReadLine();
                        break;
                    }
            }
        }

    }
}
