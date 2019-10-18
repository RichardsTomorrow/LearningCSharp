//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TicTacToe
//{
//    class Choice
//    {

//        private int ValidPress(){
//            bool validPress = false;
//            int press = 0;
//         while (!validPress)
              
//            {
                
//                validPress = Int32.TryParse(Console.ReadLine(), out press);
                
//                if (press < 0 || press > 9)
//                {
//                    validPress = false;
//                }
//            }
//            return press;
//        }
//        public void PressPlace(char[] arr)
//        {
//            if (arr[ValidPress()] != 'X' && arr[ValidPress()] != 'O')
//            { 
//                Turn turn = new Turn();

//                if (turn.GetIsXTurn() == false)
//                {
//                    arr[ValidPress()] = 'X';
//                }
//                else if (turn.GetIsXTurn() == true)
//                {
//                    arr[ValidPress()] = 'O';
//                }
//            }
//        }
        

//    }
//}
