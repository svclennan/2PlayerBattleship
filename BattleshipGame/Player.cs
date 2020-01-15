using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{

    abstract class Player
    {
        public string name;
        public Board ownBoard;
        public Board targetBoard;
        public List<Ship> playerShips;
        public Random rand;
    }
}