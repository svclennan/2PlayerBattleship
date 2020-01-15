using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Submarine : Ship
    {
        public Submarine(string owner, string playerType)
        {
            this.owner = owner;
            this.letter = "S";
            this.name = "Submarine";
            this.spaces = 3;
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
