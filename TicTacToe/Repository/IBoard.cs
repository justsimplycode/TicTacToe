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
        public void Display();

        public bool GetWinner(char marker);

        public bool isFull();

        public bool MakeMove(int row, int col, char marker);
    }
}
