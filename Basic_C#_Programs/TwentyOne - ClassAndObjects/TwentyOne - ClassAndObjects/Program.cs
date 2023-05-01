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
            deck deck = new deck(); //variable deck is assigned to class deck
            deck = shuffle(deck);
            
            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.ReadLine();
        }

        public static deck shuffle(deck deck)
        {
            List<card> tempList = new List<card>();
            Random random = new Random();
            while (deck.cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.cards.Count);
                tempList.Add(deck.cards[randomIndex]);
                deck.cards.RemoveAt(randomIndex);
            }
            deck.cards = tempList;
            return deck;
        }
    }
}
