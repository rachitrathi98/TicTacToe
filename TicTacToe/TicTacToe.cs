using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TicTacToe
{
    public class TicTacToe
    {
        private char[] boardArray = new char[10];
        char userLetter = ' ';
        char compLetter = ' ';
        public char[] createBoard()//Create Game by initialising char array 
        {

            for (int position = 1; position < boardArray.Length; position++)
            {
                boardArray[position] = ' ';
            }

            return boardArray;
        }
        public char selectCharacter()//Choose one letter X or O
        {
            Console.WriteLine("Select X or O");
            userLetter = Convert.ToChar(Console.ReadLine());//Take user Input
            compLetter = ' ';//For assigning the second letter after user has entered 

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
        public void displayBoard()//Displays the Board
        { 
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[1], boardArray[2], boardArray[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[4], boardArray[5], boardArray[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", boardArray[7], boardArray[8], boardArray[9]);
            Console.WriteLine("     |     |      ");
        }
        public void makeMove()
        {
            Console.WriteLine("Enter the position to mark "+ userLetter);
            int markPosition = Convert.ToInt32(Console.ReadLine());
            if (markPosition < 0 || markPosition > 10)
            {
                Console.WriteLine("Enter a Valid Position");
                makeMove();
            }
            else
            {
                if (!boardArray[markPosition].Equals(' '))
                    makeMove();
                else
                    boardArray[markPosition] = userLetter;  
            }
            displayBoard();
        }
    }
}
