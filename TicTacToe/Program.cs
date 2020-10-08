using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToe ticTacToe = new TicTacToe();
            char[] board=ticTacToe.createBoard();//Start Game
            char playerSelect=ticTacToe.selectCharacter();//Select Letter X or O by user
            int turn=ticTacToe.tossToPlay();
            while(!ticTacToe.gameOutcome()&&!ticTacToe.checkDraw())
            {
                ticTacToe.makeMove(turn);
                if (turn == 1)
                {
                    turn = 2;
                }
                else
                {
                    turn = 1;
                }
            }
            Console.WriteLine("The game has ended");
            ticTacToe.displayBoard();

        }
    }
}
