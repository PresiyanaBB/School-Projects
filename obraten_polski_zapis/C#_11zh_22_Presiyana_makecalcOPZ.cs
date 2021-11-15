using System;
using System.Collections.Generic;
using System.Linq;

namespace obraten_polski_zapis
{
    class Program
    {
        public static string output = "";

        //5+(9+8-7)*3-6-8
        //21

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MakeOPZ(input);
            Console.WriteLine();
            CalcOPZ(output);
        }

        public static void CalcOPZ(string output)
        {
            int a; int b;
            Stack<int> calc = new Stack<int>();
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == '*') { a = calc.Pop(); b = calc.Pop(); calc.Push(b * a); }
                else if (output[i] == '/') { a = calc.Pop(); b = calc.Pop(); calc.Push(b / a); }
                else if (output[i] == '+') { a = calc.Pop(); b = calc.Pop(); calc.Push(b + a); }
                else if (output[i] == '-') { a = calc.Pop(); b = calc.Pop(); calc.Push(b - a); }
                else {calc.Push(int.Parse(output[i].ToString())); }
            }
            Console.WriteLine(calc.Pop());
        }

        public static void MakeOPZ(string input)
        {
            Stack<char> znaci = new Stack<char>();
            Stack<char> opz = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') znaci.Push(input[i]);
                else if (input[i] == ')')
                {
                    while (znaci.Count > 0 && znaci.Peek() != '(')
                    {
                        opz.Push(znaci.Pop());
                    }
                    znaci.Pop();
                }
                else if (input[i] == '*' || input[i] == '/')
                {
                    if (znaci.Count == 0) znaci.Push(input[i]);
                    else
                    {
                        while (znaci.Peek() == '*' || znaci.Peek() == '/')
                        {
                            opz.Push(znaci.Pop());
                        }
                        znaci.Push(input[i]);
                    }
                }
                else if (input[i] == '+' || input[i] == '-')
                {
                    if (znaci.Count == 0) znaci.Push(input[i]);
                    else
                    {
                        while (znaci.Count > 0 && (znaci.Peek() == '*' || znaci.Peek() == '/' || znaci.Peek() == '+' || znaci.Peek() == '-'))
                        {
                            opz.Push(znaci.Pop());
                        }
                        znaci.Push(input[i]);
                    }
                }
                else
                {
                    opz.Push(input[i]);
                }
            }
            while (znaci.Count != 0) opz.Push(znaci.Pop());

            Console.WriteLine();

            foreach (var item in opz.Reverse())
            {
                output += item.ToString();
            }
            Console.WriteLine(output);
        }
    }
}
