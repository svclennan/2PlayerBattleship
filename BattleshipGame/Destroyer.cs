using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Destroyer : Ship
    {
        public Destroyer(string owner, string playerType)
        {
            this.owner = owner;
            this.letter = "D";
            this.name = "Destroyer";
            this.spaces = 2;
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
