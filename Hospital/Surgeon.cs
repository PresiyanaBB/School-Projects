using System;
using System.Collections.Generic;
using System.Text;

namespace hospital
{
    class Surgeon:Healthworker
    {
        int operacii;
        Random r = new Random();
        string zvanie = "Доцент";
        public override void Input()
        {
            base.Input();
            Console.Write("Брой операции на хирурга: ");
            operacii = int.Parse(Console.ReadLine());
            Console.Write("Звание на хирурга: ");
        }
        public Surgeon() { count++; }
        public override void View()
        {
            Console.WriteLine("Surgeon: {0,-15}   staj: {1,6}   br pacienti: {2,6}     zvanie{3,6}", ime, staj, pacienti,zvanie);
        }
        public override double Zaplata()
        {
            Console.Write("    Заплата: ");
            return  operacii* 3 + 1000;
            srednoZaplati += operacii * 3 + 1000;
        }
    }
}
