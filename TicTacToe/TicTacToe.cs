using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToe
    {
        private char[] boardArray = new char[10];
        
        public void UC_1()//Create Game by initialising char array starting with poistion 1
        {
         
            for(int position=1; position < boardArray.Length; position++)
            {
                boardArray[position] = ' ';
            }

        }
        public void UC_2()//
        {
            Console.WriteLine("Select X or 0");
            char userSelection = Convert.ToChar(Console.ReadLine());
            char compSelection = ' ';

            if (userSelection == 'X')
            {
                compSelection = '0';
            }
            else if (userSelection == '0')
            {
                compSelection = 'X';
            }
            else
            {
                Console.WriteLine("Please select correctly");
                userSelection = '-';
                compSelection = '-';
            }
        }
    }
}
