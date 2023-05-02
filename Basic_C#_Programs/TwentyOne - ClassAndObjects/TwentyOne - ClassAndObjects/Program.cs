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
            //deck = shuffle(deck);
            int timesShuffled = 0;
            deck = shuffle(deck: deck, out timesShuffled, times: 3); //making parameters named parameter to make it more readable

            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }

        public static deck shuffle(deck deck, out int timesShuffled, int times = 1) //add int times=1 to add feature to choose how many times it shuffles, optional parameter //out int timesShuffled verify the deck was shuffled a certain amount of times throwing the amount back to an already defined variable (timesShuffled)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++) //adding method overload to original method
            {
                timesShuffled++;
                List<card> tempList = new List<card>(); //VIDEO ON PAGE 213
                Random random = new Random();
                while (deck.cards.Count > 0) //grab a random card, take it out of the deck and put it into the temp deck until deck.cards.count is at 0
                {
                    int randomIndex = random.Next(0, deck.cards.Count); //takes min and max value
                    tempList.Add(deck.cards[randomIndex]); //adding random card grabbed to temp list
                    deck.cards.RemoveAt(randomIndex); //removed from list of cards
                }
                deck.cards = tempList; //assigned new temp deck to existing deck as value
            }
            return deck;
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
