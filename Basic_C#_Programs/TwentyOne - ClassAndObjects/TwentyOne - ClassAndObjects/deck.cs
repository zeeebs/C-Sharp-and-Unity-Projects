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
    }
}
