namespace TestForm.Units
{
    using System.Collections.Generic;
    using TestForm.Properties;

    public static class HeavenUnits
    {
        private static Unit sentinel = new Unit(
            attackPoints: new PointsRange(2, 4),
            defence: new PointsRange(7, 16),
            healthPoints: 25,
            squareMovements: 5,
            cost: new Cost(75),
            image: Resources.Sentinel,
            name: "Sentienl",
            count: 1);

        private static Unit crossbowman = new Unit(
            attackPoints: new PointsRange(2, 5),
            defence: new PointsRange(3, 7),
            healthPoints: 20,
            squareMovements: 5,
            cost: new Cost(110),
            image: Resources.Crossbowman,
            name: "Crossbowman",
            count: 2);

        private static Unit sister = new Unit(
            attackPoints: new PointsRange(5, 7),
            defence: new PointsRange(1, 2),
            healthPoints: 17,
            squareMovements: 5,
            cost: new Cost(105),
            image: Resources.Sister,
            name: "Sister",
            count: 3);

        private static Unit griffin = new Unit(
            attackPoints: new PointsRange(14, 18),
            defence: new PointsRange(12, 25),
            healthPoints: 80,
            squareMovements: 6,
            cost: new Cost(490),
            image: Resources.Griffin,
            name: "Griffin",
            count: 4);

        private static Unit celestial = new Unit(
            attackPoints: new PointsRange(54, 56),
            defence: new PointsRange(40, 57),
            healthPoints: 325,
            squareMovements: 6,
            cost: new Cost(2190),
            image: Resources.Celestial,
            name: "Celestial",
            count: 5);

        private static IList<Unit> deffaultUnits = new List<Unit>()
        {
            Sentinel,
            Crossbowman,
            Sister,
            Griffin,
            Celestial
        };

        static HeavenUnits()
        {
            Sentinel = sentinel;
            Crossbowman = crossbowman;
            Sister = sister;
            Griffin = griffin;
            Celestial = celestial;
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
