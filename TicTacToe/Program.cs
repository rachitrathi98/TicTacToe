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
            ticTacToe.displayBoard();
            ticTacToe.makeMove();
            ticTacToe.tossToPlay();
        }
    }
}
