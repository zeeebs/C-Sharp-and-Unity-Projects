using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne___ClassAndObjects     
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\zella\Logs\log.txt", text);
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGrad = new DateTime(2013, 6, 1, 16, 34, 22);
            //TimeSpan ageAtGrad = yearOfGrad - yearOfBirth;
            

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //constructor
                game game = new TwentyOneGame(); //polymorphism
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}





//Deck deck = new Deck(); //variable deck is assigned to class deck

//int count = deck.Cards.Count(x => x.Face == Face.Ace);
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

//deck.Shuffle(3); //making parameters

//foreach (Card card in deck.Cards)
//{
//    Console.WriteLine(card.Face + " of " + card.Suit);
//}
//Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();



//game game = new TwentyOneGame();
//game.Players = new List<Player>();
//Player player = new Player();
//player.Name = "zella";
//game += player; //=game = game + player; //basically our method for this
//game -= player; //=game = game - player;

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

//public static deck shuffle(deck deck, int times) //overload, but adds a lot of code, so can we just add the times part to the original function
//{
//    for (int i = 0; i < times; i++)
//    {
//        deck = shuffle(deck);
//    }
//    return deck;
//}
//sometimes if you have a lot of possible combos of parameters, overloading methods would be better than optional parameters, also default parameters from APIs don't work very well with optional parameters

