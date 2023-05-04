using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects     
{
    class Program
    {
        static void Main(string[] args)
        {
            game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "zella";
            game = game + player; //basically our method for this
            game = game - player;

            deck deck = new deck(); //variable deck is assigned to class deck
            deck.shuffle(3); //making parameters

            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.ReadLine();

            //inheritance example
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "zella", "gabe", "vlad" };
            //game.ListPlayers();
            //game.Play();
            //Console.ReadLine();

            //polymorphism
            //List<game> games = new List<game>();
            //game game = new TwentyOneGame();
            //games.Add(game);
            //you can make a list of object you wouldn't be able to do without polymorphism because a list would only hold one
        }



        //public static deck shuffle(deck deck, int times) //overload, but adds a lot of code, so can we just add the times part to the original function
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = shuffle(deck);
        //    }
        //    return deck;
        //}
        //sometimes if you have a lot of possible combos of parameters, overloading methods would be better than optional parameters, also default parameters from APIs don't work very well with optional parameters
    }
}
