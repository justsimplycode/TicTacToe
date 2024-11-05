using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Repository
{
    public interface IBoard
    {
        public void DisplayBoard();

        public bool CheckWin(char marker);

        public bool IsFull();

        public bool MakeMove(int row, int col, char marker);
    }
}
