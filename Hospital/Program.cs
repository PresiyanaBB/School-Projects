using System;
using System.Net.NetworkInformation;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Healthworker[] H = new Healthworker[100];

            for (int i = 0; ; i++)
            {
                Console.Write("\n\nVyvedi 1-Doctor, 2-Nurse, 3-Dentist, 4-Surgeon (for break - other number) ");

                char ch;
                do
                {
                    Healthworker k = null;
                    ch = char.Parse(Console.ReadLine());
                    if (ch == '1') k = new Doctor();
                    else if (ch == '2') k = new Nurse();
                    else if (ch == '3') k = new Dentist();
                    else if (ch == '4') k = new Surgeon();
                    else { ch = '0'; break; }
                    k.Input();
                    H[i] = k;
                    Console.WriteLine("{0:F2}", H[i].Zaplata());
                    Console.WriteLine("Broy vyvedeni = " + Healthworker.count);
                } while (ch < '1' || ch > '4');

                if (ch == '0') break;
            }

            for (int i = 0; i < Healthworker.count; i++)
            {
                H[i].View();
            }
            Console.WriteLine("sradnata zaplata e: ");
            Console.WriteLine("\nEND");
            Console.ReadKey(true);
        }
    }
}