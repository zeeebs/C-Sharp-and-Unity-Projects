using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public abstract class game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        public abstract void Play();
        public virtual void ListPlayers() //virtual method inside an abstract class means that this method gets inherited by an inheriting class but it has the ability to override it
            //have implementation but can be overridden
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
