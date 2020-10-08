using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.UC_1();//Start Game
            ticTacToe.UC_2();//Select Letter X or 0 by user
        }
    }
}
