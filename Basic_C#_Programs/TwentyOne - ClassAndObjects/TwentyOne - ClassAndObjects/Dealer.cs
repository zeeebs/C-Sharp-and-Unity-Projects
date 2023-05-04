using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class Dealer
    {
        public string Name { get; set; }
        public deck deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<card> Hand)
        {
            Hand.Add(deck.cards.First()); //First is a built in method available to a list that will grab the first item in a list
            Console.WriteLine(deck.cards.First().ToString() + "\n");
            deck.cards.RemoveAt(0); //RemoveAt is a built in method available to a list to remove from the list at index (i)
        }
    }
}
