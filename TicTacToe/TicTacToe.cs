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
        public void UC_2()//Choose one letter X or 0
        {
            Console.WriteLine("Select X or 0");
            char userLetter = Convert.ToChar(Console.ReadLine());
            char compLetter = ' ';

            if (userLetter == 'X')
            {
                compLetter = '0';
            }
            else if (userLetter == '0')
            {
                compLetter = 'X';
            }
            else
            {
                Console.WriteLine("Please select correctly");
               
            }
        }

    }
}
