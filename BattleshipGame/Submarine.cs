using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Submarine : Ship
    {
        public Submarine(string owner)
        {
            this.owner = owner;
            this.name = "Submarine";
            this.spaces = 3;
            this.startPosition = getCoordinates();
            this.direction = getDirection();
            validatePosition();
        }
    }
}
