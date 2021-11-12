using System;
using System.Collections.Generic;
using System.Text;

namespace IFigure
{
    public class Circle : IDrawable
    {
        int radius;
        public void Draw()
        {
            Console.Write("radius: ");
            radius = int.Parse(Console.ReadLine());

            double rin = radius - 0.4;
            double rout = radius + 0.4;
            char c;

            for (double y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x < rout; x += 0.5)
                {
                    double m = x * x + y * y;
                    if (m >= rin * rin && m <= rout * rout)
                    {
                        c = '*';
                    }
                    else c = ' ';
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
