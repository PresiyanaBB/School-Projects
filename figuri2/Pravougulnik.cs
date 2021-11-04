using System;
using System.Collections.Generic;
using System.Text;

namespace figuri2
{
    class Pravougulnik : Figure
    {
        public override void Input()
        {
            base.Input();
            Console.Write("b: ");
            side2 = double.Parse(Console.ReadLine());
        }
        public override double Lice()
        {
            Console.WriteLine("Лицето на правоъгълника е: ");
            return (double)side * side2;
        }
        public override double Perimetyr()
        {
            Console.WriteLine("Периметъра на правоъгълника е: ");
            return (double)2 * (side + side2);
        }
    }
}
