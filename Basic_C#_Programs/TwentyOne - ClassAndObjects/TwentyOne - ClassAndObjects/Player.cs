using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public static game operator+ (game game, Player player) //overloading the operator (operator+), its taking two operands, a game and a player, and returning a game, it takes the game and adds a player to it and returns the game
        {
            game.Players.Add(player);
            return game;
        }

        public static game operator- (game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}

//Generics video pg 254
