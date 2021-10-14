using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Clear
    {
        public static void Start()
        {
            Console.Clear();
            string s = "Банка " + DateTime.Now;
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("Банка " + DateTime.Now);

            OutKlient.DaliKlient();
        }
        public static void Starter1()
        {
            Console.Clear();
            string s = "Банка " + DateTime.Now;
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("Банка " + DateTime.Now);
        }
    }
}
