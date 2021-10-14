using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bank
{
    public class End:WholeBank,OutKlient
    {
        
        public static void ending()
        {
            Console.WriteLine("Повторно зареждане на банка? 1-да 2-не");
            int YesNo = int.Parse(Console.ReadLine());
            switch (YesNo)
            {
                case 1:
                    {
                        Clear.Start();
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Благодарим, че избрахте нашата банка :) ");
                        
                        string fName = "DataBaseBank.txt";
                        WriteToFile(fName);
                        Console.ReadLine();
                        break;
                    }
            }
        }
        public static void Options()
        {
            Console.Write("Месечен лихвен %:  ");
            Smetki.lihpro = double.Parse(Console.ReadLine());
            Console.Write("Тип сметка: 1-депозит 2-ипотека 3-кредит    :");
            int q = int.Parse(Console.ReadLine());
            try
            {
                switch (q)
                {
                    case 1:
                        {
                            OutDep.OutDepozit();
                            klienti.Add(new Depozit().ToString());
                            OutKlient.balancee[vs.IndexOf(cperson)] = OutKlient.balancee[OutKlient.balancee.Count - 1];
                            OutKlient.balancee.RemoveAt(OutKlient.balancee.Count - 1);
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            OutIp.OutIpoteka();
                            klienti.Add(new Ipoteka().ToString());
                            OutKlient.balancee[vs.IndexOf(cperson)].Equals(OutKlient.balancee[OutKlient.balancee.Count - 1]);
                            OutKlient.balancee.RemoveAt(OutKlient.balancee.Count - 1);
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            OutKr.OutKredit();
                            klienti.Add(new Kredit().ToString());
                            //klienti[klienti.IndexOf(cperson)].Replace(klienti[klienti.IndexOf(cperson)], new Kredit().ToString());
                            OutKlient.balancee[vs.IndexOf(cperson)].Equals(OutKlient.balancee[OutKlient.balancee.Count - 1]);
                            OutKlient.balancee.RemoveAt(OutKlient.balancee.Count - 1);
                            Console.WriteLine();
                            break;
                        }
                }
                Clear.Start();
            }
            catch
            {
                Clear.Starter1();
            }
        }
    }
}
