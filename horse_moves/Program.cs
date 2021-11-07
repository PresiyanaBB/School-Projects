using System;

namespace horse_moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var board = new bool [n,n];
            Horse(board,0,n);
        }

        private static void Horse(bool[,] board,int row,int col)
        {
            if (AllVisited() == true)
            {
                Console.WriteLine(AllPaths(board,row,col));
                return;
            }
        }

        private static bool AllPaths(bool[,] board, int row, int col)
        {
            throw new NotImplementedException();
        }

        private static bool AllVisited()
        {
            throw new NotImplementedException();
        }
    }
}
