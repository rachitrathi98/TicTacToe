using System;

namespace TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.createBoard();//Start Game
            ticTacToe.selectCharacter();//Select Letter X or O by user
        }
    }
}
