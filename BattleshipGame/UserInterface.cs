using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    class UserInterface
    {
        public UserInterface()
        {

        }
        public string GameType()
        {
            Console.WriteLine("Would you like to play\n1)Player vs Player\n2)Player vs Bot\n3)Bot vs Bot");
            string gameChoice = Console.ReadLine();
            switch (gameChoice)
            {
                case "1":
                    {
                        return "PvP";
                    }
                case "2":
                    {
                        return "PvB";
                    }
                case "3":
                    {
                        return "BvB";
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input.");
                        return GameType();
                    }
            }
        }

        public string GetName(string player)
        {
            Console.WriteLine("What is the name of " + player + "?");
            return Console.ReadLine();
        }
    }
}
