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
            deck.shuffle(3); //making parameters named parameter to make it more readable

            foreach (card card in deck.cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.cards.Count);
            Console.ReadLine();
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
