using System;

namespace TicTocToeBoard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Welcome to Tic Tac Toe Game..");
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            ticTacToeGame.createBoard();
            ticTacToeGame.chooseLetter();

        }
    }
}
