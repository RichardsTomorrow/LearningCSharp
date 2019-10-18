using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            

            GameBoard gameBoard = new GameBoard();
            //gameBoard.DrawBoard();
            //Choice press = new Choice();

            //gameBoard.DrawBoard();
            //gameBoard.PressPlace();
            //gameBoard.DrawBoard();
            //gameBoard.PressPlace();
            //gameBoard.DrawBoard();
            //gameBoard.PressPlace();
            gameBoard.DrawBoard();
            while (true)
            {
                //Console.Clear();
                //gameBoard.DrawBoard();
                gameBoard.PressPlace();
                gameBoard.TurnAnnouncer();
                gameBoard.DrawBoard();
                string result = gameBoard.Winner();
                
                if (result == "None")
                {
                    
                    continue;
                }
                else if(result == "Cat")
                {
                    Console.WriteLine(" It was a draw. You are both winners");
                    break;
                }
                else
                {
                    Console.WriteLine($"Congrats team {result} won!              ");
                    break;
                }
            }
        }
    
    }
}
