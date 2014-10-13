using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Hero : GameObject
    {
        public const string DeffaultHero = "Pesho";

        public readonly Unit[] DeffaultWarUNits = new Unit[7];

        private string name;

        // constructors


        public Unit[] WarUnits { get; set; }

    }
}
