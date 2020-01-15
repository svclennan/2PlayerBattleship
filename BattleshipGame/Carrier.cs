using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Carrier : Ship
    {

        public Carrier(string owner)
        {
            this.owner = owner;
            this.name = "Aircraft Carrier";
            this.spaces = 5;
            this.startPosition = getCoordinates();
            this.direction = getDirection();
            validatePosition();
        }
        
    }
}
