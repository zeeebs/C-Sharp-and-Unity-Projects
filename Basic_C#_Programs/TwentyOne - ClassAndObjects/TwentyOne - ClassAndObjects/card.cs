using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class Card //a class is just a model/design for the object, need to create instances of the class
        //examples: class=cookie cutter, object=the cookie; class=recipe, object=actual meal cooked with the recipe
    {
       public Suit Suit { get; set; } //creating property suit, can only get and set that property for class card, pubic makes it accessible to other parts of the program
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit 
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
        //they limit the possible values you can receive from a user
        //underlying data type for an enum is an integer, by default the index unless specifies with an =#
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine, 
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
