using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        private char[] boardArray = new char[10];
        
        public void UC_1()//Create Game by initialising char array 
        {
         
            for(int position=1; position < boardArray.Length; position++)
            {
                boardArray[position] = ' ';
            }

        }
        
    }
}
