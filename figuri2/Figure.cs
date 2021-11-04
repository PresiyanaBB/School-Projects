using System;
using System.Collections.Generic;
using System.Text;

namespace figuri2
{
    class Figure
    {
        protected double side;
        protected double side2;
        protected double side3;
        public virtual void Input()
        {
            Console.Write("a: ");
            side = double.Parse(Console.ReadLine());
        }
        public virtual double Lice()
        {
            return 0.0;
        }
        public virtual double Perimetyr()
        {
            return 0.0;
        }
    }
}
