using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class TicTacToe
    {
        private Char[,] gameBoard;          //< The gameboard which records all user moves

        /*
         * Default constructor
         */
        public TicTacToe()
        {
            gameBoard = new Char[3,3];      //< Initializes the gameboard to all empty spaces
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    gameBoard[i,j] = '.';
                }
            }
        }

        /*
         * Constructor only used for testing 
         */
        public TicTacToe(Char[,] board)
        {
            gameBoard = board;
        }

        /*
         * Checks every row to see if all pieces are the same
         * @return bool: True if a player has won
         */
        public bool checkWinHorizontal()
        {
            for (int i = 0; i < 3; i++)
            {
                if(gameBoard[i,0] == gameBoard[i,1] && gameBoard[i,0] == gameBoard[i,2] && gameBoard[i,0] != '.')
                {
                    return true;
                }
            }
            return false;
        }

        /*
         * Checks every column to see if all pieces are the same
         * @return bool: True if a player has won
         */
        public bool checkWinVertical()
        {
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0,i] == gameBoard[1,i] && gameBoard[0,i] == gameBoard[2,i] && gameBoard[0,i] != '.')
                {
                    return true;
                }
            }
            return false;
        }

        /*
         * Checks both diagonals to see if all pieces are the same
         * @return bool: True if a player has won
         */
        public bool checkWinDiagonal()
        {
            if(gameBoard[0,0] == gameBoard[1,1] && gameBoard[0,0] == gameBoard[2,2] && gameBoard[0,0] != '.')
            {
                return true;
            } else if(gameBoard[0, 2] == gameBoard[1, 1] && gameBoard[0, 2] == gameBoard[2, 0] && gameBoard[0, 2] != '.')
            {
                return true;
            }
            return false;
        }

        /*
         * Checks to see if there are any spaces still available\
         * @return bool: true if it is a draw
         */
        public bool checkDraw()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(gameBoard[i,j] == '.')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /*
         * Prints the current gameBoard
         */
        public void printBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i,j] + " ");
                }
                Console.Write("\n\n");
            }
        }

        /*
         * Inserts the users choice into the board
         * @return bool: False if invalid move
         */
        public bool takeTurn(int x, int y, Char player)
        {
            x--;
            y--;
            if(gameBoard[x,y] == '.')
            {
                gameBoard[x,y] = player;
                return true;
            }
            return false;
        }
    }
}
