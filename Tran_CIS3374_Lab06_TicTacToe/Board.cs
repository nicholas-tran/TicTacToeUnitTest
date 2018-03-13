using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tran_CIS3374_Lab06_TicTacToe
{
    public class Board
    {
        public int[] ticTacToeBoard = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int currentPlayer = 1;
        int previousPlayer = 2;

        public void CreateBoard()
        {
            ticTacToeBoard = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        public int CurrentPlayer()
        {
            return currentPlayer;
        }
        public void ChangePlayer()
        {
            int tempPlayer = currentPlayer;
            currentPlayer = previousPlayer;
            previousPlayer = tempPlayer;
        }
        public bool MakeMove(int i)
        {
            if (SpaceInUse(i) == 0)
            {
                if (currentPlayer == 1)
                {
                    ticTacToeBoard[i] = 1;
                    return true;
                }
                else if (currentPlayer == 2)
                {
                    ticTacToeBoard[i] = 2;
                    return true;
                }
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Move");
                return false;
            }
        }
        public int SpaceInUse(int i)
        {
            if (ticTacToeBoard[i] == 0)
            {
                return 0;
            }
            else
            {
                return ticTacToeBoard[i];
            }
        }
    }
}
