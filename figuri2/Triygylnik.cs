using System;
using System.Collections.Generic;
using System.Text;

namespace figuri2
{
    class Triygylnik : Pravougulnik
    {
        public override void Input()
        {
            base.Input();
            Console.Write("c: ");
            side3 = double.Parse(Console.ReadLine());
        }
        public override double Lice()
        {
            Console.WriteLine("Лицето на триъгълника е: ");
            double p = 0.5 * (side + side2 + side3);
            return (double)Math.Sqrt(p * (p - side) * (p - side2) * (p - side3));
        }
        public override double Perimetyr()
        {
            Console.WriteLine("Периметъра на триъгълника е: ");
            return side + side2 + side3;
        }
    }
}
