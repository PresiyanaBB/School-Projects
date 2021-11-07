using System;
using System.Collections.Generic;
using System.Text;

namespace figuri2
{
    class Kvadrat : Figure
    {
        public override void Input()
        {
            base.Input();
        }
        public override double Lice()
        {
            Console.WriteLine("Лицето на квадрата е: ");
            return (double)side * side;
        }
        public override double Perimetyr()
        {
            Console.WriteLine("Периметъра на квадрата е: ");
            return (double)4 * side;
        }
    }
}
