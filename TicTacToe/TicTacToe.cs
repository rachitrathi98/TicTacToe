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
        int HEADS = 1;
        int USER=1;
        int COMPUTER = 2;
        int turn;
        string winningPlayer;
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
                Console.WriteLine("\nYou are " + userLetter + "\nComputer is " + compLetter);
            }
            else if (userLetter == 'O')
            {
                compLetter = 'X';
                Console.WriteLine("\nYou are " + userLetter + "\nComputer is " + compLetter);
            }
            else
            {
                Console.WriteLine("Select between X and O");
                selectCharacter();
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
        public void makeMove(int player)
        {      
            if (player == USER)
            {
                while (true)
                {
                    Console.WriteLine("Enter the position to mark " + userLetter);
                    int markPosition = Convert.ToInt32(Console.ReadLine());
                    if (markPosition < 0 || markPosition > 10)
                    {
                        Console.WriteLine("Enter a Valid Position");
                    }   
                    else
                    {
                        if (!boardArray[markPosition].Equals(' '))
                        {
                            Console.WriteLine("The position is occupied enter another position");
                        }
                        else
                        {
                            boardArray[markPosition] = userLetter;
                            displayBoard();
                            break;
                        }
                        
                    }
                }
            }
            else
            {
                while (true) 
                {
                    Random random = new Random();
                    int markPosition = random.Next(1, 10);
                    Console.WriteLine("The markposition is "+markPosition);
                    if (markPosition < 0 || markPosition > 10)
                    {
                        Console.WriteLine("Enter a Valid Position");
                    }
                    else
                    {
                        if (!boardArray[markPosition].Equals(' '))
                            Console.WriteLine("This position is occupied enter another position");
                         else
                                {
                                    boardArray[markPosition] = compLetter;
                                    displayBoard();
                                    break;                               
                                }
                    }
                }

            }
                   
        }
        public int tossToPlay()
        {
            Random rand = new Random();
            int outcome = rand.Next(0, 2);
           

            if (outcome == HEADS)
            {
                Console.WriteLine("User to Play First");
                turn = USER; 
            }
            else 
            {
                Console.WriteLine("Computer to Play First");
                turn = COMPUTER;

            }
            return turn;
        }

        public bool gameOutcome()
        {
           
            char check;
            bool winnerDec = false;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    check = 'X';
                }
                else
                {
                    check = '0';
                }

                if ((boardArray[1] == check && boardArray[2] == check && boardArray[3] == check) ||
                    (boardArray[4] == check && boardArray[5] == check && boardArray[6] == check) ||
                    (boardArray[7] == check && boardArray[8] == check && boardArray[9] == check) ||
                    (boardArray[1] == check && boardArray[4] == check && boardArray[7] == check) ||
                    (boardArray[2] == check && boardArray[5] == check && boardArray[8] == check) ||
                    (boardArray[3] == check && boardArray[6] == check && boardArray[9] == check) ||
                    (boardArray[1] == check && boardArray[5] == check && boardArray[9] == check) ||
                    (boardArray[3] == check && boardArray[5] == check && boardArray[7] == check))
                {
                
                    winnerDec = true;
                    if (check == userLetter)
                    {
                        winningPlayer = "USER";
                    }
                    else
                    {
                        winningPlayer = "COMPUTER";   
                    }
                    Console.WriteLine("The winner of the game is "+winningPlayer);
                    break;
                }

            }

            return winnerDec;

        }
        public bool checkDraw()
        {
            bool Draw = false;
            if (gameOutcome())
            {
                return Draw;
            }
            else
            {
                for (int position = 1; position < boardArray.Length; position++)
                {
                    if (checkPositionAval(position))
                    {
                        Draw = false;
                        break;
                    }
                    else
                    {
                        Draw = true;
                    }
                }
                if (Draw)
                {
                    Console.WriteLine("Game Drawn");
                }
                return Draw;
            }
        }
        public bool checkPositionAval(int position)
        {
            if (boardArray[position].Equals("X") || boardArray[position].Equals("0"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
