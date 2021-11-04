using System;

namespace figuri
{
	class Figure
	{
		public double Perimetyr(double a, double b, double c)
		{
			return (a + b + c);
		}
		public double Perimetyr(double a)
		{
			return (4 * a);
		}
		public double Perimetyr(int r)
		{
			return (double)Math.PI * 2 * r;
		}
		public double Perimetyr(double a, double b)
		{
			return 2 * a + (2 * b);
		}

		//		от тук почва за лице

		public double Lice(double a, double b, double c)
		{
			double p = 0.5 * (a + b + c);
			return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
		}
		public double Lice(double a)
		{
			return a * a;
		}
		public double Lice(int r)
		{
			return (double)Math.PI * r * r;
		}
		public double Lice(double a, double b)
		{
			return a * b;
		}
	}
	class Program
	{
		static void Out()
		{

			Figure fig = new Figure();

			Console.WriteLine("1-окръжност");
			Console.WriteLine("2-квадрат");
			Console.WriteLine("3-правоъгълник");
			Console.WriteLine("4-триъгълник");
			Console.Write("Изберете фигура:  ");

			int k = int.Parse(Console.ReadLine());
			Console.WriteLine(" ");
			double a, b, c;
			int r;

			if (k == 1)
			{
				Console.WriteLine("Въведете радиус на окръжността: ");
				Console.Write("r=");
				r = int.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.WriteLine("Лицето на окръжността е = {0:F2}", fig.Lice(r));
				Console.WriteLine("Периметъра на окръжността е = {0:F2}", fig.Perimetyr(r));
			}
			else if (k == 2)
			{
				Console.WriteLine("Въведете страна на квадрат: ");
				Console.Write("a=");
				a = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.WriteLine("Лицето на квадрата e = {0:F2}", fig.Lice(a));
				Console.WriteLine("Периметъра на квадрата е = {0:F2}", fig.Perimetyr(a));
			}
			else if (k == 3)
			{
				Console.WriteLine("Въведете страни на правоъгълника: ");
				Console.Write("a=");
				a = double.Parse(Console.ReadLine());
				Console.Write("b=");
				b = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.WriteLine("Лицето на правоъгълника е = {0:F2}", fig.Lice(a, b));
				Console.WriteLine("Периметъра на правоъгълника е = {0:F2}", fig.Perimetyr(a, b));
			}
			else if (k == 4)
			{
				Console.WriteLine("Въведете страни на триъгълника: ");
				Console.Write("a=");
				a = double.Parse(Console.ReadLine());
				Console.Write("b=");
				b = double.Parse(Console.ReadLine());
				Console.Write("c=");
				c = double.Parse(Console.ReadLine());
				Console.WriteLine("");
				Console.WriteLine("Лицето на триъгълника е = {0:F2}", fig.Lice(a, b, c));
				Console.WriteLine("Периметъра на триъгълника е = {0:F2}", fig.Perimetyr(a, b, c));
			}
			else if (k < 1 || k > 4)
			{
				Console.WriteLine("Въведено е грешно число");
			}
		}
		public static void Main(string[] args)
		{
			Console.InputEncoding = System.Text.Encoding.Unicode;   //да чете кирилица
			Console.OutputEncoding = System.Text.Encoding.Unicode;

			Out();

			Console.WriteLine("");
			Console.ReadLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
