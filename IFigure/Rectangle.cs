using System;
using System.Collections.Generic;
using System.Text;

namespace IFigure
{
    public class Rectangle:IDrawable
    {
        int width;
        int height;
        public void Draw()
        {
            Console.Write("width: "); 
            width = int.Parse(Console.ReadLine());
            Console.Write("height: ");
            height = int.Parse(Console.ReadLine());

            DrawLine(this.width, '*', '*');
            for (int i = 1; i <= this.height; i++)
            {
                DrawLine(this.width, '*', ' ');
            }
            DrawLine(this.width, '*', '*');
        }

        private void DrawLine(int width, char v1, char v2)
        {
            Console.Write(v1);
            for (int i = 1; i <= width - 2; i++)
            {
                Console.Write(v2);
            }
            Console.WriteLine(v1);
        }
    }
}
