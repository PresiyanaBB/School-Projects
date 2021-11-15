using System;
using System.Collections.Generic;
using System.Linq;

namespace NedostigHrana
{
    class Program
    {
        public static string all;
        public static string who;
        public static int food = 0;
        public static int n;
        
        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            List<string> vs = new List<string>();
            string end = "End";
            
            do
            {
                all = Console.ReadLine();
                vs.Add(all);
            }
            while (vs.Count < n);
            do
            {
                who = Console.ReadLine();
                for (int i = 0; i < n ; i++)
                {
                    var what = vs[i].Split();
                    if (vs[i].StartsWith(who))
                    {
                        if(what.Count() == 4)
                        {
                            food += 10;
                        }
                        else
                        {
                            food += 5;
                        }
                    }
                }
            }
            while (who != end);
            Console.WriteLine(food.ToString());
            Console.WriteLine();
        }
    }
}
