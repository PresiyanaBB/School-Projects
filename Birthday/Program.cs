using System;
using System.Collections.Generic;

namespace Birthday
{
    class Program
    {
        public static string all;
        public static string[] s;
        static void Main(string[] args)
        {
            List<string> vs = new List<string>();
            string end = "End";
            string who;
            do
            {
                all = Console.ReadLine();
                s = all.Split(' ');
                vs.Add(s[s.Length - 1]);
            }
            while (all != end);
            who = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < vs.Count; i++)
            {
                if (vs[i].EndsWith(who))
                {
                    Console.WriteLine(vs[i].Substring(s.Length - 1, vs[i].Length));
                }
            }
            Console.WriteLine();
        }
    }
}
