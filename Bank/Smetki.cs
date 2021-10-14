using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Smetki
    {
        public static List<string> vs = new List<string>();
        public static List<int> pinNum = new List<int>();

        public static string cperson;
        public static int pin;
        public static double balance { get; set; }
        public static double lihpro { get; set; }
        public static double meseci { get; set; }
        public static void Klient(int klient)
        {
            if (klient == 1)
            {
                Console.Write("Името на лицето:   ");
                cperson = Console.ReadLine();
                if (vs.Contains(cperson))
                {
                    Console.Write("Whats your pin code:  ");
                    int code = int.Parse(Console.ReadLine());
                    
                    if (pinNum[vs.IndexOf(cperson)] == code)
                    {
                        Console.Write("Какво искате?  1-да си видя баланса    2-да си променя баланса:    ");
                        int wuw=int.Parse(Console.ReadLine());
                        switch (wuw)
                        {
                            case 1:
                                {
                                    Clear.Starter1();

                                    Console.WriteLine("Баланса на сметката на {0} е {1:F2} лв", cperson, OutKlient.balancee[vs.IndexOf(cperson)]);
                                    Console.WriteLine();
                                    End.ending();
                                    break;
                                }
                            case 2:
                                {
                                    End.Options();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Wrong pin");
                        End.ending();
                        Clear.Start();
                    }
                }
                else
                {
                    OutKlient.balancee.Add(OutKlient.zero);
                    Console.Write("PIN CODE   ");
                    pin = int.Parse(Console.ReadLine());
                    if (pin.ToString().Length != 4)
                    {
                        do
                        {
                            Console.Write("4-digit PIN CODE   ");
                            pin = int.Parse(Console.ReadLine());
                        }
                        while (pin.ToString().Length != 4);

                        if (pinNum.Contains(pin))
                        {
                            do
                            {
                                Console.WriteLine("Вече има такъв пин");
                                Console.Write("друг PIN CODE   ");
                                pin = int.Parse(Console.ReadLine());
                            }
                            while (pinNum.Contains(pin));

                            vs.Add(cperson);
                            pinNum.Add(pin);
                        }
                    }
                    else
                    {
                        if (pinNum.Contains(pin))
                        {
                            do
                            {
                                Console.WriteLine("Вече има такъв пин");
                                Console.Write("друг PIN CODE   ");
                                pin = int.Parse(Console.ReadLine());
                            }
                            while (pinNum.Contains(pin));

                            vs.Add(cperson);
                            pinNum.Add(pin);
                        }
                        else
                        {
                            vs.Add(cperson);
                            pinNum.Add(pin);
                        }
                    }
                }
            }
            else
            { 
                Console.Write("Името на фирмата:   ") ;
                cperson = Console.ReadLine();
                if (vs.Contains(cperson))
                {
                    Console.Write("Whats your pin code:  ");
                    int code = int.Parse(Console.ReadLine());

                    if (pinNum[vs.IndexOf(cperson)] == code)
                    {
                        Console.Write("Какво искате?  1-да си видя баланса    2-да си променя баланса:    ");
                        int wuw = int.Parse(Console.ReadLine());
                        switch (wuw)
                        {
                            case 1:
                                {
                                    Clear.Starter1();

                                    Console.WriteLine("Баланса на сметката на {0} е {1:F2} лв", cperson, OutKlient.balancee[vs.IndexOf(cperson)]);
                                    Console.WriteLine();
                                    End.ending();
                                    break;
                                }
                            case 2:
                                {
                                    End.Options();
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Wrong pin");
                        End.ending();
                        Clear.Start();
                    }
                }
                else
                {
                    OutKlient.balancee.Add(OutKlient.zero);
                    Console.Write("PIN CODE   ");
                    pin = int.Parse(Console.ReadLine());
                    if (pin.ToString().Length != 4)
                    {
                        do
                        {
                            Console.Write("4-digit PIN CODE   ");
                            pin = int.Parse(Console.ReadLine());
                        }
                        while (pin.ToString().Length != 4);

                        if (pinNum.Contains(pin))
                        {
                            do
                            {
                                Console.WriteLine("Вече има такъв пин");
                                Console.Write("друг PIN CODE   ");
                                pin = int.Parse(Console.ReadLine());
                            }
                            while (pinNum.Contains(pin));

                            vs.Add(cperson);
                            pinNum.Add(pin);
                        }
                    }
                    else
                    {
                        if (pinNum.Contains(pin))
                        {
                            do
                            {
                                Console.WriteLine("Вече има такъв пин");
                                Console.Write("друг PIN CODE   ");
                                pin = int.Parse(Console.ReadLine());
                            }
                            while (pinNum.Contains(pin));

                            vs.Add(cperson);
                            pinNum.Add(pin);
                        }
                        else
                        {
                            vs.Add(cperson);
                            pinNum.Add(pin);
                        }
                    }
                }
            }
            
        }
        public static void Vnasqne(int suma)
        {
           OutKlient.balancee[vs.IndexOf(cperson)] += suma;
        }
        public static void Teglene(int suma)
        {
            OutKlient.balancee[vs.IndexOf(cperson)] -= suma;
        }
    }
}
