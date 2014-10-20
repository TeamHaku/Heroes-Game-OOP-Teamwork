using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.Player
{
    public abstract class Player
    {
        // Units - Number
        private Dictionary<Unit, int> warUnits =
            new Dictionary<Unit, int>();

        protected Player(Faction faction, Dictionary<Unit, int> warUnits)
        {
            this.Faction = faction;
            this.WarUnits = warUnits;
        }

        public Faction Faction { get; private set; }

        public Dictionary<Unit, int> WarUnits
        {
            get { return this.warUnits; }
            set { this.warUnits = value; }
        }
    }
}
