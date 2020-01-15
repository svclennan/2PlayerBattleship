using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Carrier : Ship
    {

        public Carrier(string owner, string playerType, Random rand)
        {
            this.owner = owner;
            this.letter = "C";
            this.name = "Aircraft Carrier";
            this.spaces = 5;
            this.rand = rand;
            if (playerType == "BOT")
            {
                this.startPosition = getBotCoordinates();
                this.direction = getBotDirection();
                validateBotPosition();
            }
            if (playerType == "PLAYER")
            {
                this.startPosition = getPlayerCoordinates();
                this.direction = getPlayerDirection();
                validatePosition();
            }
        }
        
    }
}
