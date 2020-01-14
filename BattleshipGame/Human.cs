using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
            targetBoard = new Board();
            ownBoard = new Board();
            playerShips = BoardSetup();
        }
        public List<Ship> BoardSetup()
        {
            return new List<Ship> {new Carrier(), new Battleship(), new Submarine(), new Destroyer()};
        }
    }
}
