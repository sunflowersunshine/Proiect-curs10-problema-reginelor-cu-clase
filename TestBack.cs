using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_curs10
{
    public  class TestBack
    {

        public static void printBoard(int[,] board, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        public Boolean toPlaceOrNotToPlace(int[,] board, int row, int col, int N)
        {
            int i, j;
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1) return false;
            }
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }


        public Boolean theBoardSolver(int[,] board, int col, int N)
        {
            if (col >= N) return true;
            for (int i = 0; i < N; i++)
            {
                if (toPlaceOrNotToPlace(board, i, col, N))
                {
                    board[i, col] = 1;
                    if (theBoardSolver(board, col + 1, N)) return true;
                    // Backtracking is hella important in this one.  
                    board[i, col] = 0;
                }
            }
            return false;
        }
    }
}
