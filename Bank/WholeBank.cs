using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Bank
{
    public class WholeBank:Smetki, OutKlient
    {
        public static List<string> klienti = new List<string>();
        public static void RunBank()
        {
            for (int i = 0; ; i++)
            {
                Clear.Start();
                Console.Write("Месечен лихвен %:  ");
                Smetki.lihpro = double.Parse(Console.ReadLine());
                Console.Write("Тип сметка: 1-депозит 2-ипотека 3-кредит    :");
                int q = int.Parse(Console.ReadLine());
                switch (q)
                {
                    case 1:
                        {
                            OutDep.OutDepozit();
                            klienti.Add((new Depozit()).ToString());
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            OutIp.OutIpoteka();
                            klienti.Add((new Ipoteka()).ToString());
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            OutKr.OutKredit();
                            klienti.Add((new Kredit()).ToString());
                            Console.WriteLine();
                            break;
                        }
                }
            }
            
        }
        public static void WriteToFile(string fName)
        {
            StreamWriter sWriter = new StreamWriter(fName, false);
            using (sWriter)
            {
                for (int i = 0; i < vs.Count ; i++)
                {
                   sWriter.WriteLine("Клиент:  {0,15}  |    Пин код:    {1,8}   |   Баланс по сметка:   {2,16:F2} ", vs[i], pinNum[i], OutKlient.balancee[i]);
                }
                Console.Write("Банката е записана във файла.");
                Console.ReadKey();
            }
        }
    }
}
