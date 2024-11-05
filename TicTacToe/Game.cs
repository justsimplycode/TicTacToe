using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models;
using TicTacToe.Repository;

namespace TicTacToe
{
    public class Game
    {
        private IBoard _board;
        private Player _player1;
        private Player _player2;
        private Player _currentPlayer;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            _currentPlayer = player1;
            _board = new Board();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!!");
            _board.DisplayBoard();

            while (true)
            {
                Console.WriteLine($"{_currentPlayer.Name}'s Turn ({_currentPlayer.Marker})");
                int row = Convert.ToInt32(Console.ReadLine());
                int col = Convert.ToInt32(Console.ReadLine());

                if(_board.MakeMove(row, col, _currentPlayer.Marker))
                {
                    _board.DisplayBoard();

                    //check for win
                    if (_board.CheckWin(_currentPlayer.Marker))
                    {
                        Console.WriteLine($"{_currentPlayer.Name} wins!");
                        break;
                    }

                    //if the board is full it is a tie
                    if (_board.IsFull())
                    {
                        Console.WriteLine("It's a tie!");
                        break;
                    }

                    //if noone won and the board isn't full
                    //then switch players
                    _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }
        }
    }
}
