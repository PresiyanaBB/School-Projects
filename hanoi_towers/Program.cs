using System;

namespace hanoi_towers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDisk = int.Parse(Console.ReadLine());
            Towers(numDisk - 1, 'A', 'C','B') ;
            Console.WriteLine($"moves: {Math.Pow(2, numDisk) - 1}");
        }

        private static void Towers(int numDisk, char mfrom, char mto, char spare)
        {
            if (numDisk == 0)
            {
                Console.WriteLine($"disk {numDisk + 1} move from {mfrom} to {mto}");
                return;
            }
            Towers(numDisk - 1, mfrom, spare, mto);
            Console.WriteLine($"disk {numDisk + 1} move from {mfrom} to {mto}");
            Towers(numDisk - 1, spare, mto, mfrom);
        }
    }
}
