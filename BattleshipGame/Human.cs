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
            this.rand = new Random();
            rand.Next();
            ShipSetup();
            BoardSetup();
        }
        public void ShipSetup()
        {
            playerShips = new List<Ship> { new Carrier(name, "PLAYER",rand), new Battleship(name, "PLAYER"), new Submarine(name,"PLAYER"), new Destroyer(name,"PLAYER") };
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
                        BoardSetup();
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
