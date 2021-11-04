using System;
using System.Net.NetworkInformation;

namespace figuri2
{
    class Program
    { 
        static void Out()
        {
            Figure fig ;

            Console.WriteLine("1-окръжност");
            Console.WriteLine("2-квадрат");
            Console.WriteLine("3-правоъгълник");
            Console.WriteLine("4-триъгълник");
            Console.Write("Изберете фигура:  ");

            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            switch (k)
            {
                case 1:
                    {
                        fig = new Circle();
                        fig.Input();
                        Console.WriteLine(" ");
                        Console.WriteLine("{0:F2}", fig.Lice());
                        Console.WriteLine("{0:F2}", fig.Perimetyr());
                        break;
                    }
                case 2:
                    {
                        fig = new Kvadrat();
                        fig.Input();
                        Console.WriteLine(" ");
                        Console.WriteLine("{0:F2}", fig.Lice());
                        Console.WriteLine("{0:F2}", fig.Perimetyr());
                        break;
                    }
                case 3:
                    {
                        fig = new Pravougulnik();
                        fig.Input();
                        Console.WriteLine(" ");
                        Console.WriteLine("{0:F2}", fig.Lice());
                        Console.WriteLine("{0:F2}", fig.Perimetyr());
                        break;
                    }

                case 4:
                    {
                        fig = new Triygylnik();
                        fig.Input();
                        Console.WriteLine(" ");
                        Console.WriteLine("{0:F2}", fig.Lice());
                        Console.WriteLine("{0:F2}", fig.Perimetyr());
                        break;
                    }
            }
            if (k < 1 || k > 4) Console.WriteLine("Грешни данни");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Figuri 2");
            Console.WriteLine("");

            Out();

            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
