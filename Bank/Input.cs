using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public interface Input
    {
        public static int mesec;
        public static void InputAll()
        {
            Console.Write("бр месеци: ");
            mesec = int.Parse(Console.ReadLine());
            Console.Write("сума: ");
        }

    }
}
