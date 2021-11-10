using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToeBoard
{
    class TicTacToeGame
    {
        public void UC1TikTacToe()
        {
            char[] board = new char[10] { ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        
            for(int i=1;i<board.Length;i++)
            {
                Console.WriteLine(board[i]);
            }
        }
    }
}
