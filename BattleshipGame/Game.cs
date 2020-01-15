using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BattleshipGame
{
    class Game
    {
        Player p1;
        Player p2;
        UserInterface userInterface;
        public Game()
        {
            userInterface = new UserInterface();
        }
        public void ChooseGameType()
        {
            string gameChoice = userInterface.GameType();
            Console.Clear();
            switch (gameChoice)
            {
                case "PvP":
                    {
                        p1 = new Human(userInterface.GetName("Player 1"));
                        Console.Clear();
                        p2 = new Human(userInterface.GetName("Player 2"));
                        break;
                    }
                case "PvB":
                    {
                        p1 = new Human(userInterface.GetName("Player 1"));
                        p2 = new Bot(userInterface.GetName("the Bot"));
                        break;
                    }
                case "BvB":
                    {
                        p1 = new Bot(userInterface.GetName("Bot 1"));
                        Console.Clear();
                        p2 = new Bot(userInterface.GetName("Bot 2"));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Your code is misspelled");
                        break;
                    }
            }
        }
    }
}
