using TicTacToe.Models;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("shaswat", 'X');
            Player player2 = new Player("aniket", 'O');

            Game game = new Game(player1, player2);
            game.Start();
        }
    }
}
