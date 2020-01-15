using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Battleship : Ship
    {
        public Battleship(string owner, string playerType)
        {
            this.owner = owner;
            this.letter = "B";
            this.name = "Battleship";
            this.spaces = 4;
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
