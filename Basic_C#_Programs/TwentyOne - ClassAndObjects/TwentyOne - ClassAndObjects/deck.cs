using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class deck
    {
        public deck() //constructor = values assigned to an object upon creation, always same name as class
        {
            cards = new List<card>(); //proprty of class deck //creating empty list of cards
            List<string> suits = new List<string>() { "clubs", "hearts", "diamonds", "spades" };
            List<string> faces = new List<string>()
            {
                "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "jack", "queen", "king", "ace"
            };
            //2 more lists (suits and faces) instantiated immediately
            foreach (string face in faces)
            {
                foreach (string suit in suits)
                {
                    card card = new card();
                    card.suit = suit;
                    card.face = face;
                    cards.Add(card); 
                    //for each of these items in the faces list we loop through 4 times (number of suits) and each loop we create a card and we assign a suit property, a face proprty, and add it to the empty cards list
                }
            }


        }
        public List<card> cards { get; set; }

        public void shuffle(int times = 1) //add int times=1 to add feature to choose how many times it shuffles, optional parameter //out int timesShuffled verify the deck was shuffled a certain amount of times throwing the amount back to an already defined variable (timesShuffled)
        {
            for (int i = 0; i < times; i++) //adding method overload to original method
            {
                List<card> tempList = new List<card>(); //VIDEO ON PAGE 213
                Random random = new Random();
                while (cards.Count > 0) //grab a random card, take it out of the deck and put it into the temp deck until deck.cards.count is at 0
                {
                    int randomIndex = random.Next(0, cards.Count); //takes min and max value
                    tempList.Add(cards[randomIndex]); //adding random card grabbed to temp list
                    cards.RemoveAt(randomIndex); //removed from list of cards
                }
                cards = tempList; //assigned new temp deck to existing deck as value
            }
        }
    }
}
