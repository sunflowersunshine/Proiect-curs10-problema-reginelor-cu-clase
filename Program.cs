using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_curs10
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("State the value of N in this program!");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] board = new int[N, N];
            var boardSolver =  new TestBack().theBoardSolver(board, 0, N);
            if (!boardSolver)
            {
                Console.WriteLine("Solution not found.");
            }
            TestBack.printBoard(board, N);
            Console.ReadLine();
        }
    }
}
