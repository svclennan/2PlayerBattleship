using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class Bot : Player
    {
        public Bot(string name)
        {
            this.name = name;
            targetBoard = new Board();
            ownBoard = new Board();
            this.rand = new Random();
            this.rand.Next();
            ShipSetup();
            BoardSetup();
        }
        public void ShipSetup()
        {
            playerShips = new List<Ship> { new Carrier(name, "BOT", this.rand), new Battleship(name, "BOT"), new Submarine(name, "BOT"), new Destroyer(name, "BOT") };
        }
        public void BoardSetup()
        {
            foreach (Ship fleet in playerShips)
            {
                string startString = fleet.startPosition;
                char startColumn = startString[0];
                int startRow = Convert.ToInt32(startString.Remove(0, 1));
                for (int i = 0; i < fleet.spaces; i++)
                {
                    if (!ownBoard.set(startColumn - 65, startRow, fleet.letter))
                    {
                        ShipSetup();
                        break;
                    }
                    if (fleet.direction == "down")
                    {
                        startRow++;
                    }
                    if (fleet.direction == "right")
                    {
                        startColumn++;
                    }
                }
            }
            ownBoard.print();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
