using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToeBoard
{
    class TicTacToeGame
    {
        public void createBoard()
        {
            char[] board = new char[10] { ' ',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        
            for(int i=0;i<board.Length;i++)
            {
                Console.WriteLine(board[i]);
            }
        }

    /*    public void chooseLetter()
        {
            Console.WriteLine("\n Enter your letter for game");
            char playerletter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n Player letter is " + playerletter);

            char compuetLetter = 'o';
            Console.WriteLine("the computer letter is " + compuetLetter);

        }*/
    }
}
