using System;

namespace IFigure
{
    class Program
    {

        static void Main(string[] args)
        {
            for(int i =0; ;i++)
            {
                Console.WriteLine("1-Rectangle  2-Circle");
                int k = int.Parse(Console.ReadLine());
                switch (k)
                {
                    case 1:
                        {
                            Rectangle fig1 = new Rectangle();
                            fig1.Draw();
                            break;
                        }
                    case 2:
                        {
                            Circle fig2 = new Circle();
                            fig2.Draw();
                            break;
                        }
                }
                Console.WriteLine();
            }
        }
    }
}
