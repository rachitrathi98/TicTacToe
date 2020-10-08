using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
  
        public char[] createBoard()//Create Game by initialising char array 
        {
            char[] boardArray = new char[10];
            for (int position=1; position < boardArray.Length; position++)
            {
                boardArray[position] = ' ';
            }

            return boardArray;
        }
        public char selectCharacter()//Choose one letter X or O
        {
            Console.WriteLine("Select X or O");
            char userLetter = Convert.ToChar(Console.ReadLine());//Take user Input
            char compLetter=' ';//For assigning the second letter after user has entered 

            if (userLetter == 'X')
            {
                compLetter = 'O';
            }
            else if (userLetter == 'O')
            {
                compLetter = 'X';
            }
            else
            {
                Console.WriteLine("Select Properly");
            }
            return compLetter;

    }
}
