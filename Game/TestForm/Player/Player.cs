using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Player
{
    using TestForm.Interfaces;

    public abstract class Player : GameObject, IPlayer
    {
        private IList<Unit> units;

        protected Player(Faction faction, IList<Unit> units)
            : base("Player", 0, 0)
        {
            this.Faction = faction;
            this.Units = units;
        }

        public Faction Faction { get; private set; }

        public IList<Unit> Units
        {
            get 
            {
                return this.units; 
            }
            set
            {
                this.units = value; 
            }
        }
    }
}
