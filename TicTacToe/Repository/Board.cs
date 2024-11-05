using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Repository
{
    public class Board : IBoard
    {
        private char[,] _grid;

        public Board()
        {
            _grid = new char[3, 3];
            InitializeBoard();
        }

        public void Display()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Console.Write($"{_grid[i, j]}  ");
                Console.WriteLine();
        }

        public bool GetWinner(char marker)
        {
            //check diagonals for a win
            if ((_grid[0,0] == marker && _grid[1, 1] == marker && _grid[2, 2] == marker) 
                || 
                (_grid[0, 2] == marker && _grid[1, 1] == marker && _grid[2, 0] == marker))
            {
                return true;
            }

            //check rows and columns for a win
            for(int i = 0; i < 3; i++)
            {
                if((_grid[i, 0] == marker && _grid[i, 1] == marker && _grid[i, 2] == marker) 
                    || 
                    (_grid[0, i] == marker && _grid[1, i] == marker && _grid[2, i] == marker))
                {
                    return true;
                }
            }

            return false;
        }

        public bool isFull()
        {
            foreach (char cell in _grid)
                if (cell == '-')
                    return false;
            return true;
        }

        public bool MakeMove(int row, int col, char marker)
        {
            if(row >= 0 && row < 3 && col >=0 && col < 3 && _grid[row,col] == '-')
            {
                _grid[row,col] = marker;
                return true;
            }

            return false;
        }

        #region private methods

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    _grid[i, j] = '-';
        }

        #endregion
    }
}
