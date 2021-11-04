using System;
using System.Collections.Generic;
using System.Text;

namespace figuri2
{
    class Circle : Figure
    {
        public override void Input()
        {
            base.Input();
        }
        public override double Lice()
        {
            Console.WriteLine("Лицето на кръга е: ");
            return (double)Math.PI * side * side;
        }
        public override double Perimetyr()
        {
            Console.WriteLine("Периметъра на кръга е: ");
            return (double)Math.PI * 2 * side;
        }
    }
}
