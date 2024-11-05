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

        public string Marker { get; set; }

        public Player(string Name, string Marker)
        {
            this.Name = Name;
            this.Marker = Marker;
        }
    }
}
