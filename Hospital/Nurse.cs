using System;
using System.Collections.Generic;
using System.Text;

namespace hospital
{
    class Nurse:Healthworker
    {
        public Nurse() { count++; }
        public override void Input()
        {
            base.Input();
        }
        public override void View()
        {
            Console.WriteLine("Nurse: {0,-15}   staj: {1,6}   br pacienti: {2,6}", ime, staj, pacienti);
        }
        public override double Zaplata()
        {
            Console.Write("Заплата: ");
            return pacienti * 3 + 100;
            srednoZaplati += pacienti * 3 + 100;
        }
    }
}
