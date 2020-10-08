using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        private char[] boardArray = new char[10];
        
        public void UC1()
        {
            Console.WriteLine("UC1");
            for(int position=1; position < boardArray.Length; position++)
            {
                Console.WriteLine("Hi");
                boardArray[position] = ' ';
            }

        }
    }
}
