﻿namespace Game.Units
{
    public static class HeavenUnits
    {
        private static Unit sentinel;
        private static Unit crossbowman;
        private static Unit sister;
        private static Unit griffin;
        private static Unit celestial;

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

        public static Unit Crossbowman
        {
            get
            {
                return crossbowman;
            }

            private set
            {
                crossbowman = new Unit(
                   attackPoints: new PointsRange(2, 5),
                   defence: new PointsRange(3, 7),
                   healthPoints: 20,
                   squareMovements: 5,
                   cost: new Cost(110));
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
                sister = new Unit(
                   attackPoints: new PointsRange(5, 7),
                   defence: new PointsRange(1, 2),
                   healthPoints: 17,
                   squareMovements: 5,
                   cost: new Cost(105));
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
                griffin = new Unit(
                   attackPoints: new PointsRange(14, 18),
                   defence: new PointsRange(12, 25),
                   healthPoints: 80,
                   squareMovements: 6,
                   cost: new Cost(490));
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
                celestial = new Unit(
                   attackPoints: new PointsRange(54, 56),
                   defence: new PointsRange(40, 57),
                   healthPoints: 325,
                   squareMovements: 6,
                   cost: new Cost(2190));
            }
        }

    }
}
