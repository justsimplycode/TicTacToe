using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Player
    {
        public string Name { get; set; }

        public char Marker { get; set; }

        public Player(string Name, char Marker)
        {
            this.Name = Name;
            this.Marker = Marker;
        }
    }
}
