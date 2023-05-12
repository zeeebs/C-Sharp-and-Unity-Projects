using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne___ClassAndObjects
{
    public abstract class game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        
        public Dictionary<Player, int> Bets { get { return _bets; } set {_bets = value; } }

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
