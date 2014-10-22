namespace TestForm.Units
{
    using System.Collections.Generic;
    using System.Drawing;

    using TestForm.Properties;

    public class HeavenUnit : Unit
    {
        private static Unit sentinel = new HeavenUnit(
            attackPoints: new PointsRange(2, 4),
            defence: new PointsRange(7, 16),
            healthPoints: 25,
            squareMovements: 5,
            cost: new Cost(75),
            image: Resources.Sentinel,
            name: "Sentienl",
            count: 20);

        private static Unit crossbowman = new HeavenUnit(
            attackPoints: new PointsRange(2, 5),
            defence: new PointsRange(3, 7),
            healthPoints: 20,
            squareMovements: 5,
            cost: new Cost(110),
            image: Resources.Crossbowman,
            name: "Crossbowman",
            count: 20);

        private static Unit sister = new HeavenUnit(
            attackPoints: new PointsRange(5, 7),
            defence: new PointsRange(1, 2),
            healthPoints: 17,
            squareMovements: 5,
            cost: new Cost(105),
            image: Resources.Sister,
            name: "Sister",
            count: 0);

        private static Unit griffin = new HeavenUnit(
            attackPoints: new PointsRange(14, 18),
            defence: new PointsRange(12, 25),
            healthPoints: 80,
            squareMovements: 6,
            cost: new Cost(490),
            image: Resources.Griffin,
            name: "Griffin",
            count: 0);

        private static Unit celestial = new HeavenUnit(
            attackPoints: new PointsRange(54, 56),
            defence: new PointsRange(40, 57),
            healthPoints: 325,
            squareMovements: 6,
            cost: new Cost(2190),
            image: Resources.Celestial,
            name: "Celestial",
            count: 0);

        private static IList<Unit> deffaultUnits = new List<Unit>()
        {
            Sentinel,
            Crossbowman,
            Sister,
            Griffin,
            Celestial
        };

        static HeavenUnit()
        {
            Sentinel = sentinel;
            Crossbowman = crossbowman;
            Sister = sister;
            Griffin = griffin;
            Celestial = celestial;
        }

         public HeavenUnit(PointsRange attackPoints, PointsRange defence, int healthPoints, int squareMovements, Cost cost, Image image, string name, int count)
            : base(attackPoints, defence, healthPoints, squareMovements, cost, image, name, count)
        {
        }

        public static Unit Sentinel
        {
            get
            {
                return sentinel;
            }

            private set
            {
                sentinel = value;
            }
        }

        public static Unit Crossbowman
        {
            get
            {
                return crossbowman;
            }

            private set
            {
                crossbowman = value;
            }
        }

        public static Unit Sister
        {
            get
            {
                return sister;
            }

            private set
            {
                sister = value;
            }
        }

        public static Unit Griffin
        {
            get
            {
                return griffin;
            }

            private set
            {
                griffin = value;
            }
        }

        public static Unit Celestial
        {
            get
            {
                return celestial;
            }

            private set
            {
                celestial = value;
            }
        }

        public static IList<Unit> DeffaultUnits
        {
            get
            {
                return deffaultUnits;
            }

            private set
            {
                deffaultUnits = value;
            }
        }
    }
}
