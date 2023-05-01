using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public class card //a class is just a model/design for the object, need to create instances of the class
        //examples: class=cookie cutter, object=the cookie; class=recipe, object=actual meal cooked with the recipe
    {
       
        public string suit { get; set; } //creating property suit, can only get and set that property for class card, pubic makes it accessible to other parts of the program
        public string face { get; set; }
    }
}
