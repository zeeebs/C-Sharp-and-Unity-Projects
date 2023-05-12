using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class Player
    {
        public Player(string name, int beginningBalance) //taking two arguments and assigning them to the properties of the class/object
            //constructor
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bets(int amount)
        {
            if (Balance - amount < 0)
            { 
                Console.WriteLine("You do not have enough to place a bet that size");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

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
