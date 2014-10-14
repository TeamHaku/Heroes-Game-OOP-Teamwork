using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Player
{
    public abstract class Player
    {
        public Faction Faction { get; private set; }

        public Dictionary<Unit, int> WarUNits =
            new Dictionary<Unit, int>();

        protected Player(Faction faction)
        {
            this.Faction = faction;
        }
    }
}
