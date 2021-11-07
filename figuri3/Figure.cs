using System;
using System.Collections.Generic;
using System.Text;

namespace figuri2
{
    abstract class Figure
    {
        protected double side;
        protected double side2;
        protected double side3;
        public virtual void Input()
        {
            Console.Write("a: ");
            side = double.Parse(Console.ReadLine());
        }
        public abstract double Lice();
        public abstract double Perimetyr();
    }
}
