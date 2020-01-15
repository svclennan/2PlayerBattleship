using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Destroyer : Ship
    {
        public Destroyer(string owner)
        {
            this.owner = owner;
            this.name = "Destroyer";
            this.spaces = 2;
            this.startPosition = getCoordinates();
            this.direction = getDirection();
            validatePosition();
        }
    }
}
