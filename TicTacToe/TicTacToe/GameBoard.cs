using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    
    public class GameBoard
    {
        private int turnNumber = 0;
        private char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void DrawBoard()
        { // draws the actual playing board
            DrawAt(0, 0, $" {arr[1]} | {arr[2]} | {arr[3]} ");
            DrawAt(0, 1, $"---+---+---");
            DrawAt(0, 2, $" {arr[4]} | {arr[5]} | {arr[6]} ");
            DrawAt(0, 3, $"---+---+---");
            DrawAt(0, 4, $" {arr[7]} | {arr[8]} | {arr[9]} ");
            // draws the square guides
            //DrawAt(15, 0, " 1 | 2 | 3 ");
            //DrawAt(15, 1, "---+---+---");
            //DrawAt(15, 2, " 4 | 5 | 6 ");
            //DrawAt(15, 3, "---+---+---");
            //DrawAt(15, 4, " 7 | 8 | 9 ");

            DrawAt(0, 6, $"Turns alternate between X and O. Choose a spot by number.\n");
        }
        public void DrawAt(int x, int y, string row)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(row);
        }


        private bool PlayerTurn()
        {
            if (turnNumber % 2 == 0)
            {

                return true;
            }
            else//(turnNumber % 2 == 1)
            {
                return false;
            }
        }
       
        public void PressPlace()
        {
            int press;
            bool validPress = Int32.TryParse(Console.ReadLine(), out press);

            if(press < 0 || press > 9)
            {
                validPress = false;
            }

                if (validPress == true)
             {
                if (arr[press] != 'X' && arr[press] != 'O')
                {
                    if (PlayerTurn() == true)
                    {
                        arr[press] = 'X';
                        turnNumber++;
                    }
                    else if (PlayerTurn() == false)
                    {
                        arr[press] = 'O';
                        turnNumber++; 
                    }
                }
                else
                {
                    DrawAt(0,10,"You picked an invalid spot");
                }
            }
            else if (validPress == false)
            {
                Console.Clear();
                DrawAt(0,10,"You failed at numbers");
                
            }            
        }

        public string Winner() // returns "X", "O", "Draw" "Nobody" // borrowed and fixed Logic from Peter Thorsteinson
        {
            // check to see if X won yet
            if ((arr[1] == 'X' && arr[2] == 'X' && arr[3] == 'X') || // row 1
                (arr[4] == 'X' && arr[5] == 'X' && arr[6] == 'X') || // row 2
                (arr[7] == 'X' && arr[8] == 'X' && arr[9] == 'X') || // row 3
                (arr[1] == 'X' && arr[4] == 'X' && arr[7] == 'X') || // col 1
                (arr[2] == 'X' && arr[5] == 'X' && arr[8] == 'X') || // col 2
                (arr[3] == 'X' && arr[6] == 'X' && arr[9] == 'X') || // col 3
                (arr[1] == 'X' && arr[5] == 'X' && arr[9] == 'X') || // diag 1
                (arr[3] == 'X' && arr[5] == 'X' && arr[7] == 'X'))   // diag 2
                return "X";

            // check to see if O won yet
            if ((arr[1] == 'O' && arr[2] == 'O' && arr[3] == 'O') || // row 1
                (arr[4] == 'O' && arr[5] == 'O' && arr[6] == 'O') || // row 2
                (arr[7] == 'O' && arr[8] == 'O' && arr[9] == 'O') || // row 3 
                (arr[1] == 'O' && arr[4] == 'O' && arr[7] == 'O') || // col 1
                (arr[2] == 'O' && arr[5] == 'O' && arr[8] == 'O') || // col 2
                (arr[3] == 'O' && arr[6] == 'O' && arr[9] == 'O') || // col 3
                (arr[1] == 'O' && arr[5] == 'O' && arr[9] == 'O') || // diag 1
                (arr[3] == 'O' && arr[5] == 'O' && arr[7] == 'O'))   // diag 2
                return "O";

            // max number of completed moves is 9 so if we are at move 9, nobody won
            if (turnNumber == 9) return "Cat";

            return "None";
        }
        public string TurnAnnouncer()
        {
            if (string.Equals(Winner(), "None"))
            {
                if (PlayerTurn() == false)
                {
                    DrawAt(0, 8, "It is now Os turn");
                }
                else //if (PlayerTurn() == false)
                {
                    DrawAt(0, 8, "It is now Xs turn");
                }
            }
            return "";
            
        }
    }
}
