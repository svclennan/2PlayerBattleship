using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    abstract public class Ship
    {
        public string name;
        public string startPosition;
        public string direction;
        public int spaces;
        public string owner;
        public string getCoordinates()
        {
            Console.WriteLine($"{owner}, where do you want to start your {name}?(Order: LetterNumber)");
            string startPos = Console.ReadLine().ToUpper();
            int row = -1;
            if (startPos.Length == 3 || startPos.Length == 2)
            {
                char column = startPos[0];
                string rowString = startPos.Remove(0,1);
                if (column < Convert.ToChar(65) || column > Convert.ToChar(84))
                {
                    Console.WriteLine("Invalid letter.");
                    getCoordinates();
                }
                try
                {
                    row = Convert.ToInt32(rowString);
                }
                catch(Exception)
                {
                    Console.WriteLine("That is not a number.");
                    getCoordinates();
                }
                if (row < 0 || row > 20)
                {
                    Console.WriteLine("Invalid number");
                    getCoordinates();
                }
                return startPos;
            }
            else
            {
                Console.WriteLine("Enter a 2 digit string.");
                return getCoordinates();
            }
        }
        public string getDirection()
        {
            Console.WriteLine($"Do you want your {name} to go down or to the right?");
            string dir = Console.ReadLine().ToLower();
            switch (dir)
            {
                case "down":
                    {
                        return "down";
                    }
                case "right":
                    {
                        return "right";
                    }
                default:
                    {
                        Console.WriteLine("Invalid input.");
                        return getDirection();
                    }
            }
        }
        public void validatePosition()
        {
            string rowString = startPosition.Remove(0, 1);
            switch (direction)
            {
                case "right":
                    {
                        if (startPosition[0] > 85 - spaces)
                        {
                            Console.WriteLine("Chosen position is too close to the edge.");
                            startPosition = getCoordinates();
                            direction = getDirection();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "down":
                    {
                        if(Convert.ToInt32(rowString) > 21 - spaces)
                        {
                            Console.WriteLine("Chosen position is too close to the edge.");
                            startPosition = getCoordinates();
                            direction = getDirection();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("This shouldn\'t be possible? Maybe?");
                        break;
                    }
            }
        }
    }

}
