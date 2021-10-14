using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface OutDep:OutKlient,Input
    {
        public static void OutDepozit()
        {
            Depozit dep = new Depozit();
            Console.Write("1-внасяне 2-теглене 3-лихвата    :");
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
                        Input.InputAll();
                        Smetki.Teglene(int.Parse(Console.ReadLine()));
                        Console.WriteLine("балансът е {0:F2}лв ", OutKlient.balancee[Smetki.vs.IndexOf(Smetki.cperson)] - dep.MesLihva(Smetki.lihpro, k, mesec));
                        balancee.Add(OutKlient.balancee[Smetki.vs.IndexOf(Smetki.cperson)] - dep.MesLihva(Smetki.lihpro, k, mesec));
                        ISmetki.Balansirane();
                        break;
                    }
                case 3:
                    {
                        Console.Write("бр месеци: ");
                        int mesec = int.Parse(Console.ReadLine());
                        Console.WriteLine("лихвен % = {0}  , месечна лихва: {1:F2}  ", Depozit.lihpro, dep.MesLihva(Smetki.lihpro, k, mesec));
                        Console.ReadLine();
                        break;
                    }

            }
        }
    }
        
}
