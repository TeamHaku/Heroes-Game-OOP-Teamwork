using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.WarUnits
{
    using Game.Units;

    public static class HeavenUnits
    {
        private static Unit sentinel;

        public static Unit Sentinel
        {
            get
            {
                return sentinel;
            }

            private set
            {
                sentinel = new Unit(
                   attackPoints: new PointsRange(2, 4),
                   defence: new PointsRange(7, 16),
                   healthPoints: 25,
                   squareMovements: 5,
                   cost: new Cost(75));
            }
        }


        //Crossbowman,
        //Sister,
        //Griffin,
        //Celestial
    }
}
