using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class Deck
    {
        public Deck() //constructor = values assigned to an object upon creation, always same name as class
        {
            Cards = new List<Card>(); //proprty of class deck //creating empty list of cards
            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i; //casting int j to Face
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1) //add int times=1 to add feature to choose how many times it shuffles, optional parameter //out int timesShuffled verify the deck was shuffled a certain amount of times throwing the amount back to an already defined variable (timesShuffled)
        {
            for (int i = 0; i < times; i++) //adding method overload to original method
            {
                List<Card> tempList = new List<Card>(); //VIDEO ON PAGE 213
                Random random = new Random();
                while (Cards.Count > 0) //grab a random card, take it out of the deck and put it into the temp deck until deck.cards.count is at 0
                {
                    int randomIndex = random.Next(0, Cards.Count); //takes min and max value
                    tempList.Add(Cards[randomIndex]); //adding random card grabbed to temp list
                    Cards.RemoveAt(randomIndex); //removed from list of cards
                }
                Cards = tempList; //assigned new temp deck to existing deck as value
            }
        }
    }
}
