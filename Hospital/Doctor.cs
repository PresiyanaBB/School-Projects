using System;
using System.Collections.Generic;
using System.Text;

namespace hospital
{
    class Doctor:Healthworker
    {
        public Doctor() { count++; }
        public override void Input()
        {
            base.Input();
        }
        public override void View()
        {
            Console.WriteLine("Doctor: {0,-15}   staj: {1,6}   br pacienti: {2,6}",ime,staj,pacienti);
        }
        public override double Zaplata()
        {
            Console.Write("Заплата: ");
            return staj * 2 + 1500;
            srednoZaplati += staj*2+1500;
        }
    }
}
