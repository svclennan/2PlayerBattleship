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
        public string letter;
        public Random rand;
        public string getPlayerCoordinates()
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
                    getPlayerCoordinates();
                }
                try
                {
                    row = Convert.ToInt32(rowString);
                }
                catch(Exception)
                {
                    Console.WriteLine("That is not a number.");
                    getPlayerCoordinates();
                }
                if (row < 0 || row > 20)
                {
                    Console.WriteLine("Invalid number");
                    getPlayerCoordinates();
                }
                return startPos;
            }
            else
            {
                Console.WriteLine("Enter a 2 digit string.");
                return getPlayerCoordinates();
            }
        }
        public string getPlayerDirection()
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
                        return getPlayerDirection();
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
                        if (startPosition[0] > 84 - spaces)
                        {
                            Console.WriteLine("Chosen position is too close to the edge.");
                            startPosition = getPlayerCoordinates();
                            direction = getPlayerDirection();
                            validatePosition();
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
                            startPosition = getPlayerCoordinates();
                            direction = getPlayerDirection();
                            validatePosition();
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
        public string getBotCoordinates()
        {
            string column = getBotColumn();
            int row = getBotRow();
            return column + row;
        }
        public string getBotColumn()
        {
            return Convert.ToChar(rand.Next(65,85)).ToString();
        }
        public int getBotRow()
        {
            return rand.Next(1, 22);
        }
        public string getBotDirection()
        {
            int choice = rand.Next(0, 2);
            if (choice == 0)
            {
                return "right";
            }
            else
            {
                return "down";
            }
        }
        public void validateBotPosition()
        {
            string rowString = startPosition.Remove(0, 1);
            switch (direction)
            {
                case "right":
                    {
                        if (startPosition[0] > 84 - spaces)
                        {
                            Console.WriteLine("Too close to edge. " + startPosition[0]);
                            startPosition = getBotCoordinates();
                            direction = getBotDirection();
                            validateBotPosition();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "down":
                    {
                        if (Convert.ToInt32(rowString) > 21 - spaces)
                        {
                            Console.WriteLine("To close to edge. " + rowString);
                            startPosition = getBotCoordinates();
                            direction = getBotDirection();
                            validateBotPosition();
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
