using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Battleship : Ship
    {
        public Battleship(string owner)
        {
            this.owner = owner;
            this.name = "Battleship";
            this.spaces = 4;
            this.startPosition = getCoordinates();
            this.direction = getDirection();
            validatePosition();
        }
    }
}
