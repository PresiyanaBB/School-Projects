using System;
using System.Collections.Generic;
using System.Text;

namespace hospital
{
    abstract class Healthworker
    {
        protected string ime;
        protected int staj;
        protected int pacienti;
        public static int count = 0;
        public static double srednoZaplati = 0;
        public virtual void Input()
        {
            Console.Write("име : ");
            ime=Console.ReadLine();
            Console.Write("стаж в години: ");
            staj = int.Parse(Console.ReadLine());
            Console.WriteLine("брой пациенти: ");
            pacienti = int.Parse(Console.ReadLine());
           
        }
        public abstract void View();
        public abstract double Zaplata();

        public double srzap()
        {
          return srednoZaplati / count;
        }

    }
}
