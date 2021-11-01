using System;
using System.Collections.Generic;

namespace broilka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Queue<int> deca = new Queue<int>();
            for(int i = 1 ; i <= n ; i++)
            {
                deca.Enqueue(i);
            }
            while (deca.Count != 1)
            {
                for (int i = 1; i <= m; i++)
                {
                    if (i == m) deca.Dequeue();
                    else
                    {
                        deca.Enqueue(deca.Dequeue());
                    }
                }
            }
            Console.WriteLine(deca.Dequeue());
        }
    }
}
