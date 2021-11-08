using System;
using System.Collections.Generic;
using System.Text;

namespace hospital
{
    class Dentist:Healthworker
    {
        public Dentist() { count++; }
        public override void Input()
        {
            base.Input();
        }
        public override void View()
        {
            Console.WriteLine("Dentist: {0,-15}   staj: {1,6}   br pacienti: {2,6}", ime, staj, pacienti);
        }
        public override double Zaplata()
        {
            Console.Write("Заплата: ");
            return pacienti + 200;
            srednoZaplati += pacienti + 200;
        }
    }
}
