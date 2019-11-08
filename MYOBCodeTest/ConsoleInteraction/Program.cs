using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic;

namespace ConsoleInteraction
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();   
            String line;                        //Line entered by user
            int playerNum = 1;                  //Player number initialized to 1
            char playerLetter = 'X';            //Player Letter initialized to X
            bool validTurn = false;             //If user input is a valid move

            Console.Write("Welcome to Tic Tac Toe!\n\n");
            Console.Write("Here's the current board:\n\n");
            game.printBoard();

            while (true)
            {
                Console.Write("Player " + playerNum + " enter a coord x,y to place your " + playerLetter + " or enter 'q' to give up: ");
                line = Console.ReadLine();
                if(line == "q")
                {
                    //Checks if player wants to give up
                    Console.Write("\nPlayer " + playerNum + " has given up.");
                    break;
                }
                try
                {
                    //Try catch to ensure that user input is what was expected and the entered coords are in range
                    string[] coords = line.Split(',');
                    validTurn = game.takeTurn(Convert.ToInt32(coords[0]), Convert.ToInt32(coords[1]), playerLetter);
                } catch(Exception e)
                {
                    Console.Write("\nOh no, please enter a valid location! Try again...\n\n");
                    continue;
                }
                if (!validTurn){
                    Console.Write("\nOh no, a piece is already at this place! Try again...\n\n");
                    continue;
                } else
                {   //Checks all possible win conditions
                    if(game.checkWinHorizontal() || game.checkWinVertical() || game.checkWinDiagonal())
                    {
                        Console.Write("\nMove accepted, well done you've won the game!\n\n");
                        game.printBoard();
                        break;
                    }//Checks for a draw
                    else if(game.checkDraw())
                    {
                        Console.Write("\nMove accepted, the game is a draw!\n\n");
                        game.printBoard();
                        break;
                    }
                    else
                    {//Continues the game and swaps players
                        Console.Write("\nMove accepted, here's the current board:\n\n");
                        game.printBoard();
                        if(playerNum == 1)
                        {
                            playerNum = 2;
                            playerLetter = 'O';
                        }
                        else
                        {
                            playerNum = 1;
                            playerLetter = 'X';
                        }
                    }
                }
            }
            Console.ReadLine(); //Holds so the Console window doesn't close
        }
    }
}
