using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Player
{
    public abstract class Player
    {
        private IList<Unit> units;

        protected Player(Faction faction, IList<Unit> units)
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
